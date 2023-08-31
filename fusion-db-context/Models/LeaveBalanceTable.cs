using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class LeaveBalanceTable
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int LeavePolicyId { get; set; }
        public int LeavesTaken { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }

        public virtual Employeedatum Emp { get; set; }
        public virtual LeavePolicyTable LeavePolicy { get; set; }
    }
}
