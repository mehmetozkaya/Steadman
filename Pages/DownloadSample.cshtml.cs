using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mosh.Entity;
using Mosh.Service;

namespace Mosh.Pages
{
    public class DownloadSampleModel : PageModel
    {
        private readonly IMailService _mailService;

        public DownloadSampleModel(IMailService mailService)
        {
            _mailService = mailService ?? throw new ArgumentNullException(nameof(mailService));
        }

        [BindProperty]
        public Mail Mail { get; set; } = new Mail();

        public string Message { get; set; } = string.Empty;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _mailService.Insert(Mail);
                Message = "We thank you for your interest. We will finish the book in a very short time. We will send it to you when we are finished.";
            }

            return Page();
        }
    }
}