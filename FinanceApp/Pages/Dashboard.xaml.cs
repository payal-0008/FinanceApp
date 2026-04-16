using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Dashboard : ContentPage
{
    public Dashboard()
    {
        InitializeComponent();
        LoadDashboardData();
    }

    private void LoadDashboardData()
    {
        WeeklyList.ItemTemplate = DailyList.ItemTemplate;
        MonthlyList.ItemTemplate = DailyList.ItemTemplate;

        // Daily
        DailyList.ItemsSource = new List<DashboardTransaction>
        {
            new DashboardTransaction { Title = "Food", Date = "18:27 - April 09", TypeName = "Daily", Amount = "$2", Icon = "grocery.png", AmountColor = Colors.Black },
            new DashboardTransaction { Title = "Transport", Date = "17:00 - April 24", TypeName = "Fuel", Amount = "-$30", Icon = "car.png", AmountColor = Color.FromArgb("#3F51B5") },
            new DashboardTransaction { Title = "Pet", Date = "8:30 - April 15", TypeName = "Pet", Amount = "-$40", Icon = "paw.png", AmountColor = Color.FromArgb("#3F51B5") }
        };

        // Weekly
        WeeklyList.ItemsSource = new List<DashboardTransaction>
        {
            new DashboardTransaction { Title = "Shopping", Date = "18:27 - April 30", TypeName = "Weekly", Amount = "$60", Icon = "right.png", AmountColor = Colors.Black },
            new DashboardTransaction { Title = "Medicine", Date = "17:00 - April 24", TypeName = "Medical", Amount = "-$30", Icon = "medicine.png", AmountColor = Color.FromArgb("#3F51B5") },
            new DashboardTransaction { Title = "House Help", Date = "12:00 - April 14", TypeName = "Laundry", Amount = "-$20", Icon = "laundry_machine.png", AmountColor = Color.FromArgb("#3F51B5") }
        };

        // Monthly
        MonthlyList.ItemsSource = new List<DashboardTransaction>
        {
            new DashboardTransaction { Title = "Salary", Date = "18:27 - April 30", TypeName = "Monthly", Amount = "$4,000", Icon = "money.png", AmountColor = Colors.Black },
            new DashboardTransaction { Title = "Rent", Date = "8:30 - April 15", TypeName = "Rent", Amount = "-$674", Icon = "house_key.png", AmountColor = Color.FromArgb("#3F51B5") },
            new DashboardTransaction { Title = "Groceries", Date = "17:30 - April 24", TypeName = "Grocery", Amount = "-$100,00", Icon = "grocery.png", AmountColor = Color.FromArgb("#3F51B5") }
        };
    }

    private void OnTabTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter == null) return;
        int selectedColumn = int.Parse(e.Parameter.ToString());

        Grid.SetColumn(SelectionIndicator, selectedColumn);

        DailyList.IsVisible = (selectedColumn == 0);
        WeeklyList.IsVisible = (selectedColumn == 1);
        MonthlyList.IsVisible = (selectedColumn == 2);
    }

    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
}