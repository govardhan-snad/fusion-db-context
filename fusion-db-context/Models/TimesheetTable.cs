using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class TimesheetTable
    {
        public int TimesheetId { get; set; }
        public int EmpId { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public DateTime WeekStartDate { get; set; }
        public DateTime WeekEndDate { get; set; }
        public DateTime? Createdat { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? Updatedat { get; set; }

        public virtual Employeedatum Emp { get; set; }
        public virtual Project Project { get; set; }
        public virtual TaskTable Task { get; set; }
    }
}
