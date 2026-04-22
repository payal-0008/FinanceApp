using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Rent : ContentPage
{
    public ObservableCollection<RentHistoryGroup> GroupedRentData { get; set; } = new();

    public Rent()
    {
        InitializeComponent();
        LoadRentData();
    }

    private void LoadRentData()
    {
        // Monthly Data Setup
        var aprilItems = new List<TransactionModel> { new TransactionModel { Name = "Rent", Date = "18:27 - April 15", Amount = "-$674,40", Icon = "house_key.png" } };
        var marchItems = new List<TransactionModel> { new TransactionModel { Name = "Rent", Date = "15:00 - March 15", Amount = "-$674,40", Icon = "house_key.png" } };
        var febItems = new List<TransactionModel> { new TransactionModel { Name = "Rent", Date = "11:47 - February 15", Amount = "-$674,40", Icon = "house_key.png" } };
        var janItems = new List<TransactionModel> { new TransactionModel { Name = "Rent", Date = "18:47 - January 15", Amount = "-$674,40", Icon = "house_key.png" } };

        GroupedRentData.Clear();
        GroupedRentData.Add(new RentHistoryGroup("April", aprilItems));
        GroupedRentData.Add(new RentHistoryGroup("March", marchItems));
        GroupedRentData.Add(new RentHistoryGroup("February", febItems));
        GroupedRentData.Add(new RentHistoryGroup("January", janItems));

        RentList.ItemsSource = GroupedRentData;
    }

    private async void Back(object sender, EventArgs e) { await Navigation.PopAsync(); }
    private async void notification(object sender, EventArgs e) { await Navigation.PushAsync(new Notification()); }
    private async void OnAddExpensesClick(object sender, EventArgs e) { await Navigation.PushAsync(new AddExpenses()); }
}