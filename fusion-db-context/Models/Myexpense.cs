using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Myexpense
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? Expensedate { get; set; }
        public decimal? Amount { get; set; }
        public string Attachment { get; set; }
        public string Status { get; set; }
        public int ExpensesCode { get; set; }
        public string Description { get; set; }
        public bool IsManagementExpense { get; set; }

        public virtual Expense ExpensesCodeNavigation { get; set; }
    }
}
