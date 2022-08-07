using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models
{
    public class Student:BaseEntity
    {
        [Key]
        public int StudenId { get; set; }

    }
}
