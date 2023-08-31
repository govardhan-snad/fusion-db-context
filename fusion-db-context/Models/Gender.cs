using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Gender
    {
        public int Sno { get; set; }
        public string GenderName { get; set; }
        public string Isdeleted { get; set; }
    }
}
