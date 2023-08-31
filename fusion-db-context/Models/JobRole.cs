using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class JobRole
    {
        public JobRole()
        {
            ProjectsRoles = new HashSet<ProjectsRole>();
        }

        public int Sno { get; set; }
        public string JobRole1 { get; set; }
        public string Isdeleted { get; set; }

        public virtual ICollection<ProjectsRole> ProjectsRoles { get; set; }
    }
}
