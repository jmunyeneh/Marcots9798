using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcotsContactApp.Data;
using MarcotsContactApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MarcotsContactApp.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //TODO: Birthdays of the month
        public IList<Person> Person { get; set; }

        public bool IsRecordAvailable { get; set; } = true;
        public async Task OnGetAsync()
        {
            DateTime start = DateTime.Now;
            int month = start.Month;
            int day = start.Day;

            var context = _context.Contact.Where(x => x.BirthMonth == month);

            if (context.Any() == true)
            {
                Person = await context.ToListAsync();
                IsRecordAvailable = true;
            }else
            {

                IsRecordAvailable = false;
            }
            
        }
    }
}
