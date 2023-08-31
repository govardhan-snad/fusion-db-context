using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Assignment
    {
        public int AssignmentId { get; set; }
        public int Prid { get; set; }
        public int EmpId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? Createdat { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? Updatedat { get; set; }
        public int? ProjectId { get; set; }

        public virtual Employeedatum Emp { get; set; }
        public virtual ProjectsRole Pr { get; set; }
        public virtual Project Project { get; set; }
    }
}
