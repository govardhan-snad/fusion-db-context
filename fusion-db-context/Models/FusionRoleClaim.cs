using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class FusionRoleClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string RoleId { get; set; }

        public virtual FusionRole Role { get; set; }
    }
}
