using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class IdentityTable
    {
        public int IdentityId { get; set; }
        public int EmpId { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public string Attachment { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Employeedatum Emp { get; set; }
    }
}
