using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Educationdatum
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public string Specialization { get; set; }
        public double? Gpa { get; set; }
        public DateTime? DegreeStartDate { get; set; }
        public DateTime? DegreeEndDate { get; set; }
        public string Status { get; set; }

        public virtual Employeedatum Employee { get; set; }
    }
}
