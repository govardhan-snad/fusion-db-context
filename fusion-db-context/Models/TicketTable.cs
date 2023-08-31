using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class TicketTable
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? SubdeptId { get; set; }
        public string DeskNo { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string TicketStatus { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string StepsToReplicate { get; set; }
        public string Comments { get; set; }
        public string AttachmentUrl { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? Isdeleted { get; set; }
        public int? AssigneeId { get; set; }

        public virtual Employeedatum Assignee { get; set; }
        public virtual Employeedatum Emp { get; set; }
        public virtual SubDepartment Subdept { get; set; }
    }
}
