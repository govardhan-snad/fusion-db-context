using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Department
    {
        public Department()
        {
            SubDepartments = new HashSet<SubDepartment>();
        }

        public int Sno { get; set; }
        public string DepartmentName { get; set; }
        public string Isdeleted { get; set; }

        public virtual ICollection<SubDepartment> SubDepartments { get; set; }
    }
}
