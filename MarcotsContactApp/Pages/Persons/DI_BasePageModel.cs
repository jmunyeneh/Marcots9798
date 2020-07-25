using MarcotsContactApp.Data;
using MarcotsContactApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcotsContactApp.Pages.Persons
{
    public class DI_BasePageModel : PageModel
    {
        protected ApplicationDbContext Context { get; }
        protected IAuthorizationService AuthorizationService { get; }
        protected UserManager<IdentityUser> UserManager { get; }

        protected MarcotsContext _context;

        public DI_BasePageModel(
            ApplicationDbContext context,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager
            , MarcotsContext _context1
            ) : base()
        {
            Context = context;
            UserManager = userManager;
            AuthorizationService = authorizationService;
            _context = _context1;
        }
    }
}
