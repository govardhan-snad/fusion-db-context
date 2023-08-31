using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class OfferLetterTable
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public DateTime? OfferSentDate { get; set; }
        public string OfferSentStatus { get; set; }
        public int? OfferSentBy { get; set; }
        public string DocumentUrl { get; set; }
        public bool Isdeleted { get; set; }
        public string Status { get; set; }

        public virtual Employeedatum Emp { get; set; }
        public virtual Employeedatum OfferSentByNavigation { get; set; }
    }
}
