using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Models
{
    public class TransactionModel
    {
        public string? Name { get; set; }
        public string? Date { get; set; }
        public string? Category { get; set; }
        public string? Amount { get; set; }
        public string? Icon { get; set; }
        public string? Type { get; set; }

        public Color AmountColor =>
            Type?.ToLower() == "expense" ? Colors.Red : Colors.Green;
    }
}
