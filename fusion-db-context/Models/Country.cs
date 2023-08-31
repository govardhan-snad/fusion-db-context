using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Country
    {
        public int Sno { get; set; }
        public string CountryName { get; set; }
        public string Currency { get; set; }
    }
}
