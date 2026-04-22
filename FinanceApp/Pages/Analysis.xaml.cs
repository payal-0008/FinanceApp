namespace FinanceApp.Pages;

public partial class Analysis : ContentPage
{
    Color activeTabColor = (Color)Application.Current.Resources["MainColor"];
    Color inactiveTabColor = Colors.Transparent;
    Color activeTextColor = (Color)Application.Current.Resources["Black"];
    Color inactiveTextColor = (Color)Application.Current.Resources["Gray600"];
    public Analysis()
	{
		InitializeComponent();
	}
    private void OnTabTapped(object sender, EventArgs e)
    {
        var border = (Border)sender;
        var tapGesture = (TapGestureRecognizer)border.GestureRecognizers[0];
        string selectedTab = tapGesture.CommandParameter.ToString();

        ResetTabUI();
        switch (selectedTab)
        {
            case "Daily":
                UpdateUI(DailyBorder, DailyLabel, "$4,120.00", "1,187.40");
                UpdateChartBars(60, 110, 40, 80, 100, 50, 30);
                break;
            case "Weekly":
                UpdateUI(WeeklyBorder, WeeklyLabel, "$11,420.00", "20,000.20");
                UpdateChartBars(80, 130, 20, 60, 90, 40, 110);
                break;
            case "Monthly":
                UpdateUI(MonthlyBorder, MonthlyLabel, "$47,200.00", "35,510.20");
                UpdateChartBars(120, 70, 140, 100, 60, 130, 80);
                break;
            case "Year":
                UpdateUI(YearBorder, YearLabel, "$430,560.00", "320,300.00");
                UpdateChartBars(100, 120, 110, 140, 100, 90, 130);
                break;
        }
    }

    private void UpdateUI(Border activeBorder, Label activeLabel, string income, string expenses)
    {
        activeBorder.BackgroundColor = activeTabColor;
        activeLabel.TextColor = activeTextColor;
        activeLabel.FontAttributes = FontAttributes.Bold;

        IncomeValue.Text = income;
        ExpenseValue.Text = expenses;
    }

    private void ResetTabUI()
    {
        DailyBorder.BackgroundColor = WeeklyBorder.BackgroundColor =
            MonthlyBorder.BackgroundColor = YearBorder.BackgroundColor = inactiveTabColor;

        DailyLabel.TextColor = WeeklyLabel.TextColor =
        MonthlyLabel.TextColor = YearLabel.TextColor = inactiveTextColor;

        DailyLabel.FontAttributes = WeeklyLabel.FontAttributes =
        MonthlyLabel.FontAttributes = YearLabel.FontAttributes = FontAttributes.None;
    }
    private void UpdateChartBars(double b1, double b2, double b3, double b4, double b5, double b6, double b7)
    {
        Bar1.HeightRequest = b1;
        Bar2.HeightRequest = b2;
        Bar3.HeightRequest = b3;
        Bar4.HeightRequest = b4;
        Bar5.HeightRequest = b5;
        Bar6.HeightRequest = b6;
        Bar7.HeightRequest = b7;
    }
    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void search(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Search());
    }
    private async void calender(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Calender());
    }
}