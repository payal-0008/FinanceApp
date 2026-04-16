using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Transport : ContentPage
{
    public ObservableCollection<TransportHistoryGroup> GroupedTransportData { get; set; } = new();

    public Transport()
    {
        InitializeComponent();
        LoadTransportData();
    }

    private void LoadTransportData()
    {
        // March Data
        var marchItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Fuel", Date = "18:27 - March 30", Amount = "-$3.53", Icon = "car.png", Type = "Expense" },
            new TransactionModel { Name = "Car Parts", Date = "15:00 - March 30", Amount = "-$26.75", Icon = "car.png", Type = "Expense" }
        };

        // February Data
        var febItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "New Tires", Date = "20:50 - February 10", Amount = "-$373.99", Icon = "car.png", Type = "Expense" },
            new TransactionModel { Name = "Car Wash", Date = "09:30 - February 9", Amount = "-$9,74", Icon = "car.png", Type = "Expense" },
            new TransactionModel { Name = "Public Transport", Date = "07:50 - February 2", Amount = "-$1,24", Icon = "car.png", Type = "Expense" }
        };

        GroupedTransportData.Clear();
        GroupedTransportData.Add(new TransportHistoryGroup("March", marchItems));
        GroupedTransportData.Add(new TransportHistoryGroup("February", febItems));

        TransportList.ItemsSource = GroupedTransportData;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();
    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
    private async void OnAddExpensesClick(object sender, EventArgs e) => await Navigation.PushAsync(new AddExpenses());
}