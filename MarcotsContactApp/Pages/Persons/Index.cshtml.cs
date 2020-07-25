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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using MarcotsContactApp.Authorization;
using System.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarcotsContactApp
{
    public class IndexModel : DI_BasePageModel
    {
        public IndexModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager, MarcotsContext _context)
            : base(context, authorizationService, userManager, _context)
        {
        }    
        public IList<ContactsDTO> Person { get;set; }
        //Modified by JMunyeneh, 7/22/20
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public async Task OnGetAsync()
        {           

            var contacts = from c in Context.Contact
                            join m in Context.Months on c.BirthMonth equals m.MonthId
                            join s in Context.MarStatus on c.StatusId equals s.Id
                           select new ContactsDTO
                           {
                               PersonId = c.PersonId,
                               ContactStatus = c.ContactStatus,
                               MonthName =  m.MonthName,
                               Description= s.Description,
                               OwnerId = c.OwnerId,
                               FirstName= c.FirstName,
                               MidName =  c.MidName,
                               LastName = c.LastName,
                               NickName =  c.NickName,
                               Telephone = c.Telephone,
                               Kids =  c.Kids,
                               Email = c.Email,
                               Occupation = c.Occupation,
                               BirthDay = c.BirthDay,
                               BirthMonth = m.MonthName,
                               MaritalDesc = c.Status.Description
                           };

            //Modified by JMunyeneh, 7/22/20
            if (!string.IsNullOrEmpty(SearchString))
            {
                contacts = contacts.Where(f => f.FirstName.Contains(SearchString));
            }

            var isAuthorized = User.IsInRole(Constants.ContactManagersRole) ||
                           User.IsInRole(Constants.ContactAdministratorsRole);

            var currentUserId = UserManager.GetUserId(User);

            // Only approved contacts are shown UNLESS you're authorized to see them
            // or you are the owner.
            if (!isAuthorized)
            {
                contacts = contacts.Where(c => c.ContactStatus == ContactStatus.Approved
                                            || c.OwnerId == currentUserId);
            }

            Person = await contacts.ToListAsync();
        }
    }
}
