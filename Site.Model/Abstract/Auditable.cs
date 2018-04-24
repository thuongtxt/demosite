using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { set; get; }
        [MaxLength(226)]
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(226)]
        public string UpdatedBy { set; get; }

        [MaxLength(2)]
        public string MetaKeyword { set; get; }
        [MaxLength(2)]
        public string MetaDescription { set; get; }

        public bool Status { get; set; }

    }
}
