using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarcotsContactApp.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarcotsContactApp.Pages.Contacts
{
    public class IndexModel : PageModel
    {
        public IndexModel(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
        [BindProperty]
        public EmailInfo info { get; set; }
        private readonly IEmailSender emailSender;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            await emailSender.SendEmailAsync(info.Email, info.Name, info.Message);
            return RedirectToPage("/Contacts/Index");
        }
    }
}
