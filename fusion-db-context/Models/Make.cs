using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Make
    {
        public int Sno { get; set; }
        public string MakeName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
