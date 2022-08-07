using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models.Admin
{
    public class RegisterModel
    {
        [Required]
        [StringLength(100)]
        [EmailAddress]
        [Display(Name ="User Name")]
        public String User { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password .")]
        [Compare(nameof(Password))]
        public bool ConfirmPassword { get; set; }
    }
}
