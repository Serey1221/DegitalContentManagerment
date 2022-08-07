using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public List<Degree> Degrees { get; set; }
        public DateTime GraduatiOn { get; set; }
    }
}
