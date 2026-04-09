namespace FinanceApp.Pages;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
	}

    private void OnTabTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter == null) return;
        int selectedColumn = int.Parse(e.Parameter.ToString());
        Grid.SetColumn(SelectionIndicator, selectedColumn);
        DailyView.IsVisible = false;
        WeeklyView.IsVisible = false;
        MonthlyView.IsVisible = false;
        switch (selectedColumn)
        {
            case 0:
                DailyView.IsVisible = true;
                break;
            case 1:
                WeeklyView.IsVisible = true;
                break;
            case 2:
                MonthlyView.IsVisible = true;
                break;
        }
    }

    private async void notification(object sender,EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
}