using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Steadman.Entity;

namespace Steadman.Pages
{
    public class BookModel : PageModel
    {
        [BindProperty]
        public Mail Mail { get; set; } = new Mail();

        public string Message { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                var asd = Mail.CreateTime;
                var ss = Mail.MailAddress;
                var ee = Mail.Id;

                Message = "We thank you for your interest. We will finish the book in a very short time. We will send it to you when we are finished.";
            }


            return Page();
        }
    }
}