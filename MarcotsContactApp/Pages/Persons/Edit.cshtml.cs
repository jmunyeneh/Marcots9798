using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarcotsContactApp.Models;
using MarcotsContactApp.Pages.Persons;
using MarcotsContactApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using MarcotsContactApp.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MarcotsContactApp
{
    public class EditModel : DI_BasePageModel
    {
        public EditModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager, MarcotsContext _context)
            : base(context, authorizationService, userManager,_context)
        {
        }

        [BindProperty]
        public Person Contact { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Contact = await Context.Contact.FirstOrDefaultAsync(
                                                 m => m.PersonId == id);

            ViewData["FullName"] = Contact.FullName;

            if (Contact == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                      User, Contact,
                                                      ContactOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return Forbid();
            }

            ViewData["BirthDay"] = new SelectList(Context.Days, "DayId", "DayId");
            ViewData["BirthMonth"] = new SelectList(Context.Months, "MonthId", "MonthName");
            ViewData["StatusId"] = new SelectList(Context.MarStatus, "Id", "Description");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Fetch Contact from DB to get OwnerID.
            var contact = await Context
                .Contact.AsNoTracking()
                .FirstOrDefaultAsync(m => m.PersonId == id);

            if (contact == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                     User, contact,
                                                     ContactOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return Forbid();
            }

            Contact.OwnerId = contact.OwnerId;
            Contact.ModifiedDate = DateTime.UtcNow;
            Contact.InsertedDate = contact.InsertedDate ?? DateTime.UtcNow;

            Contact.Image = contact.Image;
            Contact.ImageContentType = contact.ImageContentType;
            

            if (Image != null)
            {
                using (var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);

                    Contact.Image = stream.ToArray();
                    Contact.ImageContentType = Image.ContentType;                   
                }
            }
            
            Context.Attach(Contact).State = EntityState.Modified;

            if (Contact.ContactStatus == ContactStatus.Approved)
            {
                // If the contact is updated after approval, 
                // and the user cannot approve,
                // set the status back to submitted so the update can be
                // checked and approved.
                var canApprove = await AuthorizationService.AuthorizeAsync(User,
                                        Contact,
                                        ContactOperations.Approve);

                if (!canApprove.Succeeded)
                {
                    Contact.ContactStatus = ContactStatus.Submitted;
                }
            }

            await Context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }

}
