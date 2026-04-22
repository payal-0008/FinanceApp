using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Food : ContentPage
{
    public ObservableCollection<FoodGroup> GroupedFoodData { get; set; } = new();

    public Food()
    {
        InitializeComponent();
        LoadData();
    }

    void LoadData()
    {
        // April Data
        var aprilItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Dinner", Date = "18:27 - April 30", Amount = "-$26,00", Icon = "food.png", Type = "Expense" },
            new TransactionModel { Name = "Delivery Pizza", Date = "15:00 - April 24", Amount = "-$18,35", Icon = "food.png", Type = "Expense" },
            new TransactionModel { Name = "Lunch", Date = "12:30 - April 15", Amount = "-$15,40", Icon = "food.png", Type = "Expense" }
        };

        // March Data
        var marchItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Dinner", Date = "20:50 - March 31", Amount = "-$27,20", Icon = "food.png", Type = "Expense" }
        };

        GroupedFoodData.Add(new  FoodGroup("April", aprilItems));
        GroupedFoodData.Add(new FoodGroup("March", marchItems));

        FoodTransactionsList.ItemsSource = GroupedFoodData;
    }

    private async void Back(object sender, EventArgs e) { await Navigation.PopAsync(); }
    private async void notification(object sender, EventArgs e) { await Navigation.PushAsync(new Notification()); }
    private async void OnAddExpensesClick(object sender, EventArgs e) { await Navigation.PushAsync(new AddExpenses()); }
}