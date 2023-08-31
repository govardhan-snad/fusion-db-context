using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class BankDetail
    {
        public int BankId { get; set; }
        public int EmpId { get; set; }
        public long AccountNo { get; set; }
        public string AccountName { get; set; }
        public string IfscCode { get; set; }
        public string DocUrl { get; set; }
        public bool IsDeleted { get; set; }
        public string BankName { get; set; }
        public bool IsPrimary { get; set; }

        public virtual Employeedatum Emp { get; set; }
    }
}
