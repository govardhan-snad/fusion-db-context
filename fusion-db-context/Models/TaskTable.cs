using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class TaskTable
    {
        public TaskTable()
        {
            TimesheetTables = new HashSet<TimesheetTable>();
        }

        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int ProjectId { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<TimesheetTable> TimesheetTables { get; set; }
    }
}
