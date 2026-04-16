using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Groceries : ContentPage
{
    public ObservableCollection<GroceriesHistoryGroup> GroupedGroceriesData { get; set; } = new();

    public Groceries()
    {
        InitializeComponent();
        LoadGroceriesData();
    }

    private void LoadGroceriesData()
    {
        // March Data
        var marchItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Pantry", Date = "18:27 - March 10", Amount = "-$53.59", Icon = "grocery.png" },
            new TransactionModel { Name = "Snacks", Date = "15:00 - March 01", Amount = "-$35.03", Icon = "grocery.png" }
        };

        // February Data
        var febItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Canned Food", Date = "10:47 - February 30", Amount = "-$11.82", Icon = "grocery.png" },
            new TransactionModel { Name = "Vaggies", Date = "7:30 - February 20", Amount = "-$14.79", Icon = "grocery.png" },
            new TransactionModel { Name = "Groceries", Date = "18:50 - February 01", Amount = "-$175,35", Icon = "grocery.png" }
        };

        GroupedGroceriesData.Clear();
        GroupedGroceriesData.Add(new GroceriesHistoryGroup("March", marchItems));
        GroupedGroceriesData.Add(new GroceriesHistoryGroup("February", febItems));

        GroceriesList.ItemsSource = GroupedGroceriesData;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();
    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
    private async void OnAddExpensesClick(object sender, EventArgs e) => await Navigation.PushAsync(new AddExpenses());
}