using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public String Province { get; set; }
        public String District { get; set; }
        public String Village { get; set; }


        [ForeignKey(nameof(Leturer))]
        public int LeturerId { get; set; }

        //public Leturer Leturer { get; set; }
        //[InverseProperty("LeturerDobAddress")]
        //public Leturer LeturerDobAddress { get; set; }
        //[InverseProperty("LeturerPobAddress")]
        //public Leturer LeturerPobAddress { get; set; }


    }
}
