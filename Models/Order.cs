using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GameCodeHut.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Please enter a Game ID")]
        public string GameAcct { get; set; }

        public string Customer { get; set; } 

        [Required]
        public string Product { get; set; }

        public string Quantity { get; set; }

        public DateTime OrderDate { get; set; }
    }




}
