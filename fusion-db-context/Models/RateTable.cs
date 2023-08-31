using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class RateTable
    {
        public int RateId { get; set; }
        public string Country { get; set; }
        public decimal BillableRate { get; set; }
        public string Currency { get; set; }
        public int GradeId { get; set; }
        public DateTime? Createdat { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Isdeleted { get; set; }
        public decimal CostRate { get; set; }

        public virtual Gradetable Grade { get; set; }
    }
}
