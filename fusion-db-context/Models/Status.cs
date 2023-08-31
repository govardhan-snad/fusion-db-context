using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Status
    {
        public int Sno { get; set; }
        public string Statusname { get; set; }
        public string Isdeleted { get; set; }
    }
}
