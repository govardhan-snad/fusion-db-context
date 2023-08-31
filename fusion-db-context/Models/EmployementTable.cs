using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class EmployementTable
    {
        public int Id { get; set; }
        public int Empid { get; set; }
        public string JobType { get; set; }
        public DateTime? EmpEffectiveDate { get; set; }
        public string EmpComments { get; set; }
        public int? GradeId { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }

        public virtual Employeedatum Emp { get; set; }
        public virtual Gradetable Grade { get; set; }
    }
}
