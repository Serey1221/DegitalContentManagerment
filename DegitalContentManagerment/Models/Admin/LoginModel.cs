using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models.Admin
{
    public class LoginModel
    {
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Display(Name ="Remember Me.")]
        public bool RememberMe { get; set; }
    }
}
