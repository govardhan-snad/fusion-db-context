using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class LeavePolicyTable
    {
        public LeavePolicyTable()
        {
            LeaveBalanceTables = new HashSet<LeaveBalanceTable>();
            Timeoffs = new HashSet<Timeoff>();
        }

        public int LpId { get; set; }
        public int CategoryId { get; set; }
        public int GradeId { get; set; }
        public int MaxDays { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }

        public virtual LeavesCateogoryTable Category { get; set; }
        public virtual Gradetable Grade { get; set; }
        public virtual ICollection<LeaveBalanceTable> LeaveBalanceTables { get; set; }
        public virtual ICollection<Timeoff> Timeoffs { get; set; }
    }
}
