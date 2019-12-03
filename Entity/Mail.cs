using System;
using System.ComponentModel.DataAnnotations;

namespace Mosh.Entity
{
    public class Mail
    {
        public int Id { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string MailAddress { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
