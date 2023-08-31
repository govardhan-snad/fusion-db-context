using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Clienttable
    {
        public Clienttable()
        {
            Projects = new HashSet<Project>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ContactMail { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Comments { get; set; }
        public DateTime? Createdat { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? Updatedat { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
