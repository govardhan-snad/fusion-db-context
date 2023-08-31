using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class BranchLocation
    {
        public int Sno { get; set; }
        public string BranchCode { get; set; }
        public bool IsDeleted { get; set; }
        public string BranchLocation1 { get; set; }
    }
}
