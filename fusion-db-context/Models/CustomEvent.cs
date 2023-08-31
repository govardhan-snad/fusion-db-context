using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class CustomEvent
    {
        public int EventId { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventMessage { get; set; }
        public int? EmpId { get; set; }
        public bool? IsDeleted { get; set; }
        public string EventTitle { get; set; }
        public string AttachmentUrl { get; set; }

        public virtual Employeedatum Emp { get; set; }
    }
}
