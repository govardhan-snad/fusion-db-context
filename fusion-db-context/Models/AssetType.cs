using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class AssetType
    {
        public int Sno { get; set; }
        public string AssetType1 { get; set; }
        public bool IsDeleted { get; set; }
    }
}
