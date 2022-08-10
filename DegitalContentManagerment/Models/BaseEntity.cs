using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models
{
    public class BaseEntity
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String FatherName { get; set; }
        public String FatherJob { get; set; }
        public String MotherName { get; set; }
        public String MotherJob { get; set; }
        public DateTime DateofBirth { get; set; }
        [NotMapped]
        public  int Age { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ProfileImage { get; set; }
    }
}
