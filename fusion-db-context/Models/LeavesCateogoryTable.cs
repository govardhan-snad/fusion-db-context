using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class LeavesCateogoryTable
    {
        public LeavesCateogoryTable()
        {
            LeavePolicyTables = new HashSet<LeavePolicyTable>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }

        public virtual ICollection<LeavePolicyTable> LeavePolicyTables { get; set; }
    }
}
