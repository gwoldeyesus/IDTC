using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDTC.MVC.ViewModels
{
    public class ContactUsViewModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [Display(Name = "Name")]
        [DataType(DataType.Text, ErrorMessage = "Invalid data format!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Length must be between 3 and 50 characters long.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email address is required!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid data format!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required!")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid data format!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Subject is required!")]
        [DataType(DataType.Text, ErrorMessage = "Invalid data format!")]
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
