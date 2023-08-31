using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Visainformation
    {
        public int? EmployeeId { get; set; }
        public string Visatype { get; set; }
        public string Issuedcountry { get; set; }
        public DateTime? Issueddate { get; set; }
        public DateTime? Expirydate { get; set; }
        public string Vstatus { get; set; }
        public string Notes { get; set; }
        public int Id { get; set; }

        public virtual Employeedatum Employee { get; set; }
    }
}
