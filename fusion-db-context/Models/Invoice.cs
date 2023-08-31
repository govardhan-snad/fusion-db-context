using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Invoicenumber { get; set; }
        public DateTime Invoicedate { get; set; }
        public string InvoiceType { get; set; }
        public decimal? Money { get; set; }
        public string Attachment { get; set; }
        public string Status { get; set; }
        public string EmployeeName { get; set; }

        public virtual Employeedatum Employee { get; set; }
    }
}
