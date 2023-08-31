using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class FusionUserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual FusionRole Role { get; set; }
        public virtual FusionUser User { get; set; }
    }
}
