using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Timeoff
    {
        public int? EmployeeId { get; set; }
        public int? Duration { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Startdate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public double? Leavesapplied { get; set; }
        public double? Remainingleaves { get; set; }
        public int LeavePolicyId { get; set; }

        public virtual LeavePolicyTable LeavePolicy { get; set; }
    }
}
