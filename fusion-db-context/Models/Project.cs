using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Project
    {
        public Project()
        {
            Assignments = new HashSet<Assignment>();
            ProjectsRoles = new HashSet<ProjectsRole>();
            TaskTables = new HashSet<TaskTable>();
            TimesheetTables = new HashSet<TimesheetTable>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ColourId { get; set; }
        public string Description { get; set; }
        public double? MaxBillHours { get; set; }
        public double? OverTimeFactor { get; set; }
        public DateTime? Createdat { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? Updatedat { get; set; }

        public virtual Clienttable Client { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<ProjectsRole> ProjectsRoles { get; set; }
        public virtual ICollection<TaskTable> TaskTables { get; set; }
        public virtual ICollection<TimesheetTable> TimesheetTables { get; set; }
    }
}
