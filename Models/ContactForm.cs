using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameCodeHut.Models
{
    public class ContactForm
    {
        [Key]
        public int FormID { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        public DateTime DateAdded { get; set; }

    }
}
