using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Compensationdatum
    {
        public int? EmployeeId { get; set; }
        public int Id { get; set; }
        public DateTime? Compeffectivedate { get; set; }
        public string Overtimeeligibility { get; set; }
        public string Reason { get; set; }
        public string Compensationcomments { get; set; }
        public string Frequency { get; set; }
        public string Paytype { get; set; }
        public decimal? Compensationamount { get; set; }
        public string Status { get; set; }

        public virtual Employeedatum Employee { get; set; }
    }
}
