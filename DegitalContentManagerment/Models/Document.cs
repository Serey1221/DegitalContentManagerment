using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegitalContentManagerment.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public String DocumentTitle { get; set; }
        public String DocumentExtension { get; set; }
        public float? DocumentSize { get; set; }
        public String FileLocation { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public String UseId { get; set; }
    }
}
