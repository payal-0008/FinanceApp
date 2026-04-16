using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Type?.ToLower() == "expense" ? Color.FromArgb("#3F51B5") : Colors.Black;
    }
    public class FoodGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public FoodGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }
    public class TransportHistoryGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public TransportHistoryGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }
    public class MedicineHistoryGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public MedicineHistoryGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }
    public class GroceriesHistoryGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public GroceriesHistoryGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }
    public class RentHistoryGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public RentHistoryGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }

    public class GiftsHistoryGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public GiftsHistoryGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }

    public class EntHistoryGroup : ObservableCollection<TransactionModel>
    {
        public string GroupTitle { get; private set; }
        public EntHistoryGroup(string title, List<TransactionModel> items) : base(items)
        {
            GroupTitle = title;
        }
    }
}
