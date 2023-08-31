using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class OfferStatus
    {
        public int Sno { get; set; }
        public string OfferStatus1 { get; set; }
        public bool IsDeleted { get; set; }
    }
}
