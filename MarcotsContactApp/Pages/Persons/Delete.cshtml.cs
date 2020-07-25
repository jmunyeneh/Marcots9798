using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarcotsContactApp.Models;
using MarcotsContactApp.Pages.Persons;
using MarcotsContactApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using MarcotsContactApp.Authorization;

namespace MarcotsContactApp
{
    public class DeleteModel : DI_BasePageModel
    {
        public DeleteModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager, MarcotsContext _context)
            : base(context, authorizationService, userManager, _context)
        {
        }

        [BindProperty]
        public Person Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Contact = await Context.Contact.FirstOrDefaultAsync(
                                                 m => m.PersonId == id);

            if (Contact == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                     User, Contact,
                                                     ContactOperations.Delete);
            if (!isAuthorized.Succeeded)
            {
                return Forbid();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var contact = await Context
                .Contact.AsNoTracking()
                .FirstOrDefaultAsync(m => m.PersonId == id);

            if (contact == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                     User, contact,
                                                     ContactOperations.Delete);
            if (!isAuthorized.Succeeded)
            {
                return Forbid();
            }

            Context.Contact.Remove(contact);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
    /*
        public class DeleteModel : PageModel
        {
            private readonly MarcotsContactApp.Models.MarcotsContext _context;

            public DeleteModel(MarcotsContactApp.Models.MarcotsContext context)
            {
                _context = context;
            }

            [BindProperty]
            public Person Person { get; set; }

            public async Task<IActionResult> OnGetAsync(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                Person = await _context.Person
                    .Include(p => p.BirthDayNavigation)
                    .Include(p => p.BirthMonthNavigation)
                    .Include(p => p.Status).FirstOrDefaultAsync(m => m.PersonId == id);

                if (Person == null)
                {
                    return NotFound();
                }
                return Page();
            }

            public async Task<IActionResult> OnPostAsync(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                Person = await _context.Person.FindAsync(id);

                if (Person != null)
                {
                    _context.Person.Remove(Person);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");
            }
        }
    */
}
