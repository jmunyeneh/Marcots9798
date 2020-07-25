using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarcotsContactApp.Models;
using MarcotsContactApp.Pages.Persons;
using MarcotsContactApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using MarcotsContactApp.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace MarcotsContactApp
{
    public class CreateModel : DI_BasePageModel
    {
        public CreateModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager, MarcotsContext _context)
            : base(context, authorizationService, userManager, _context)
        {
        }      

        public IActionResult OnGet()
        {
            ViewData["BirthDay"] = new SelectList(Context.Days, "DayId", "DayId");
            ViewData["BirthMonth"] = new SelectList(Context.Months, "MonthId", "MonthName");
            ViewData["StatusId"] = new SelectList(Context.MarStatus, "Id", "Description");
            return Page();
        }

        [BindProperty]
        public Person Person { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Person.OwnerId = UserManager.GetUserId(User);
            Person.InsertedDate = DateTime.UtcNow;
            Person.ModifiedDate = DateTime.UtcNow;

            if(Image != null)
            {
                using(var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    Person.Image = stream.ToArray();
                    Person.ImageContentType = Image.ContentType;
                }
            }

            // requires using ContactManager.Authorization;
            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                        User, Person,
                                                        ContactOperations.Create);
            if (!isAuthorized.Succeeded)
            {
                return Forbid();
            }

            Context.Contact.Add(Person);          

            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
