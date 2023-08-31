using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class AppointmentLetterTable
    {
        public int Id { get; set; }
        public int? Empid { get; set; }
        public DateTime? AppointmentSentDate { get; set; }
        public string AppointmentSentStatus { get; set; }
        public int? AppointmentSentBy { get; set; }
        public string DocumentUrl { get; set; }
        public bool Isdeleted { get; set; }
        public string Status { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ApprovedBy { get; set; }
        public int? Approver { get; set; }
        public string Comments { get; set; }
        public string WatermarkDocUrl { get; set; }
        public DateTime? RequestedDate { get; set; }

        public virtual Employeedatum AppointmentSentByNavigation { get; set; }
        public virtual Employeedatum ApprovedByNavigation { get; set; }
        public virtual Employeedatum ApproverNavigation { get; set; }
        public virtual Employeedatum Emp { get; set; }
    }
}
