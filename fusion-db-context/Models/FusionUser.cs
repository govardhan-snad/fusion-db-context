using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class FusionUser
    {
        public FusionUser()
        {
            FusionUserClaims = new HashSet<FusionUserClaim>();
            FusionUserRoles = new HashSet<FusionUserRole>();
        }

        public string Id { get; set; }
        public string EmployeeId { get; set; }

        public virtual ICollection<FusionUserClaim> FusionUserClaims { get; set; }
        public virtual ICollection<FusionUserRole> FusionUserRoles { get; set; }
    }
}
