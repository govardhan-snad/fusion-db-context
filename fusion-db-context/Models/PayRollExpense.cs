using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class PayRollExpense
    {
        public int Employeeid { get; set; }
        public string Employeename { get; set; }
        public decimal? Totalpayrollexpenses { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
        public int Noofhours { get; set; }
        public int Payrate { get; set; }
        public int Grosspay { get; set; }
        public int Payrollexpense1 { get; set; }
        public int Insurancebycompany { get; set; }
        public DateTime? Payperiodstartdate { get; set; }
        public DateTime? Payperiodenddate { get; set; }
        public DateTime? Paymentdate { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Updateddate { get; set; }
        public int Id { get; set; }

        public virtual Employeedatum Employee { get; set; }
    }
}
