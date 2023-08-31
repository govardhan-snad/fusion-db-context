using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Jobinformation
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Department { get; set; }
        public string BussinessArea { get; set; }
        public string Lopcation { get; set; }
        public string JobRole { get; set; }
        public string Status { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
        public int? SubdeptId { get; set; }

        public virtual SubDepartment Subdept { get; set; }
    }
}
