using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class TerminationReason
    {
        public int Sno { get; set; }
        public string Reason { get; set; }
        public string Isdeleted { get; set; }
    }
}
