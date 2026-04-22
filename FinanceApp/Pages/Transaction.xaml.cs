using FinanceApp.Models;
using System.Collections.ObjectModel;

namespace FinanceApp.Pages;

public partial class Transaction : ContentPage
{
    public ObservableCollection<TransactionGroup> TransactionGroups { get; set; } = new();

    public Transaction()
    {
        InitializeComponent();
        LoadGroupedData();
    }

    private void LoadGroupedData()
    {
        // April Data
        var aprilList = new List<DashboardTransaction>
        {
            new DashboardTransaction { Title = "Salary", Date = "18:27 - April 30", TypeName = "Monthly", Amount = "$4.000,00", Icon = "money.png", AmountColor = Colors.Black },
            new DashboardTransaction { Title = "Groceries", Date = "17:00 - April 24", TypeName = "Pantry", Amount = "-$100,00", Icon = "grocery.png", AmountColor = Color.FromArgb("#3F51B5") },
            new DashboardTransaction { Title = "Rent", Date = "8:30 - April 15", TypeName = "Rent", Amount = "-$674,40", Icon = "house_key.png", AmountColor = Color.FromArgb("#3F51B5") },
            new DashboardTransaction { Title = "Transport", Date = "7:30 - April 08", TypeName = "Fuel", Amount = "-$4,13", Icon = "car.png", AmountColor = Color.FromArgb("#3F51B5") }
        };

        // March Data
        var marchList = new List<DashboardTransaction>
        {
            new DashboardTransaction { Title = "Food", Date = "19:30 - March 31", TypeName = "Dinner", Amount = "-$70,40", Icon = "food.png", AmountColor = Color.FromArgb("#3F51B5") }
        };

        // Adding to Groups
        TransactionGroups.Clear();
        TransactionGroups.Add(new TransactionGroup("April", aprilList));
        TransactionGroups.Add(new TransactionGroup("March", marchList));

        TransactionList.ItemsSource = TransactionGroups;
    }

    private async void Back(object sender, EventArgs e) { await Navigation.PopAsync(); }

    private async void notification(object sender, EventArgs e) { await Navigation.PushAsync(new Notification()); }

    private async void OnIncomeClick(object sender, EventArgs e) { await Navigation.PushAsync(new IncomeAndExpense()); }
}