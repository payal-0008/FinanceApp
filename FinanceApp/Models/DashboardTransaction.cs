using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FinanceApp.Models
{
    public class DashboardTransaction
    {
        public string? Title { get; set; }
        public string? Date { get; set; }
        public string? Amount { get; set; }
        public string? Icon { get; set; }
        public string? TypeName { get; set; }
        public Color? AmountColor { get; set; }
        public string? MonthName { get; set; }
    }
    public class TransactionGroup : ObservableCollection<DashboardTransaction>
    {
        public string Name { get; private set; }
        public TransactionGroup(string name, List<DashboardTransaction> transactions) : base(transactions)
        {
            Name = name;
        }
    }
}
