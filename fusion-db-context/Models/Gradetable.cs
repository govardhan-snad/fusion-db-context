using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Gradetable
    {
        public Gradetable()
        {
            EmployementTables = new HashSet<EmployementTable>();
            LeavePolicyTables = new HashSet<LeavePolicyTable>();
            ProjectsRoles = new HashSet<ProjectsRole>();
            RateTables = new HashSet<RateTable>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string JobGrade { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }

        public virtual ICollection<EmployementTable> EmployementTables { get; set; }
        public virtual ICollection<LeavePolicyTable> LeavePolicyTables { get; set; }
        public virtual ICollection<ProjectsRole> ProjectsRoles { get; set; }
        public virtual ICollection<RateTable> RateTables { get; set; }
    }
}
