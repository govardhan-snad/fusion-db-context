using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class FusionRole
    {
        public FusionRole()
        {
            FusionRoleClaims = new HashSet<FusionRoleClaim>();
            FusionUserRoles = new HashSet<FusionUserRole>();
        }

        public string Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public virtual ICollection<FusionRoleClaim> FusionRoleClaims { get; set; }
        public virtual ICollection<FusionUserRole> FusionUserRoles { get; set; }
    }
}
