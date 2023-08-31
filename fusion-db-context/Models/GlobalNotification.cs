using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class GlobalNotification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string SentTo { get; set; }
        public bool? IsRead { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? NotificationDate { get; set; }
        public string NotificationType { get; set; }
        public int? EmpId { get; set; }
    }
}
