using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lib.Core.Model
{
    class Portfolio
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "FullName must be between 3 and 50 chars")]
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Contact { get; set; }
        public decimal Total_Investment { get; set; }
        public string Gender { get; set; }
    }
}
