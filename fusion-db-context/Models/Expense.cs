using System;
using System.Collections.Generic;

#nullable disable

namespace fusion_db_context.Models
{
    public partial class Expense
    {
        public Expense()
        {
            Myexpenses = new HashSet<Myexpense>();
        }

        public string ExpenseType { get; set; }
        public int ExpensesCode { get; set; }
        public string Isdeleted { get; set; }

        public virtual ICollection<Myexpense> Myexpenses { get; set; }
    }
}
