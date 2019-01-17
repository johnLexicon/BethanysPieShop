using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your name is required")]
        public string Name { get; set; }

        // To tell the browser the type so it can make the correct adjustments.
        [DataType(DataType.EmailAddress)] 
        [Required]
        [StringLength(100, ErrorMessage = "Your email is required")]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Your message is required")]
        public string Message { get; set; }
        public bool ContactMe { get; set; }

    }
}
