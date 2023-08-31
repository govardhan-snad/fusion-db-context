using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class SubDepartment
    {
        public SubDepartment()
        {
            Jobinformations = new HashSet<Jobinformation>();
            TicketTables = new HashSet<TicketTable>();
        }

        public int SubdepartmentId { get; set; }
        public string SubdepartmentName { get; set; }
        public int? DepartmentId { get; set; }
        public int? ReportingmanagerId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employeedatum Reportingmanager { get; set; }
        public virtual ICollection<Jobinformation> Jobinformations { get; set; }
        public virtual ICollection<TicketTable> TicketTables { get; set; }
    }
}
