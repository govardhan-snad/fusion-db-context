using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Title
    {
        public int Sno { get; set; }
        public string Titlename { get; set; }
        public string Isdeleted { get; set; }
    }
}
