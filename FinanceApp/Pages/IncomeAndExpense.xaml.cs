using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class IncomeAndExpense : ContentPage
{
    ObservableCollection<TransactionModel> AllData = new();

    public IncomeAndExpense()
    {
        InitializeComponent();
        LoadData();
        ShowIncome(); 
    }

    void LoadData()
    {
        AllData.Add(new TransactionModel { Name = "Salary", Date = "18:27 - April 30", Category = "Monthly", Amount = "$4,000.00", Icon = "money.png", Type = "Income" });
        AllData.Add(new TransactionModel { Name = "Others", Date = "17:00 - April 24", Category = "Payments", Amount = "$120.00", Icon = "money.png", Type = "Income" });

        AllData.Add(new TransactionModel { Name = "Groceries", Date = "17:00 - April 24", Category = "Pantry", Amount = "-$100.00", Icon = "grocery.png", Type = "Expense" });
        AllData.Add(new TransactionModel { Name = "Rent", Date = "8:30 - April 15", Category = "Rent", Amount = "-$674.40", Icon = "house_key.png", Type = "Expense" });
        AllData.Add(new TransactionModel { Name = "Transport", Date = "7:30 - April 08", Category = "Fuel", Amount = "-$4.13", Icon = "car.png", Type = "Expense" });
    }

    private void OnIncomeClick(object sender, EventArgs e) => ShowIncome();
    private void OnExpenseClick(object sender, EventArgs e) => ShowExpense();

    void ShowIncome()
    {
        UpdateTabUI(IncomeBorder, IncomeLbl, IncomeAmt, true);
        UpdateTabUI(ExpenseBorder, ExpenseLbl, ExpenseAmt, false);

        TransactionList.ItemsSource = AllData.Where(x => x.Type?.ToLower() == "income").ToList();
    }

    void ShowExpense()
    {
        UpdateTabUI(ExpenseBorder, ExpenseLbl, ExpenseAmt, true);
        UpdateTabUI(IncomeBorder, IncomeLbl, IncomeAmt, false);

        TransactionList.ItemsSource = AllData.Where(x => x.Type?.ToLower() == "expense").ToList();
    }

    void UpdateTabUI(Border border, Label lbl, Label amt, bool isSelected)
    {
        var mainColor = (Color)Application.Current.Resources["MainColor"];

        border.BackgroundColor = isSelected ? mainColor : Colors.White;
        lbl.TextColor = isSelected ? Colors.Black : Colors.Black;
        amt.TextColor = isSelected ? Colors.White : (border == ExpenseBorder ? Color.FromArgb("#3F51B5") : Colors.Black);
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();

    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
}