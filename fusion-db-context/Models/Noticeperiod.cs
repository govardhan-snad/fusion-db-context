using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Noticeperiod
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public string Isdeleted { get; set; }
    }
}
