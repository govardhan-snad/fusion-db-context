using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class ProjectsRole
    {
        public ProjectsRole()
        {
            Assignments = new HashSet<Assignment>();
        }

        public int Prid { get; set; }
        public int ProjectId { get; set; }
        public int RoleId { get; set; }
        public int GradeId { get; set; }
        public decimal BillableRate { get; set; }
        public bool? IsBillabe { get; set; }
        public DateTime? Createdat { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? Updatedat { get; set; }

        public virtual Gradetable Grade { get; set; }
        public virtual Project Project { get; set; }
        public virtual JobRole Role { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}
