namespace FinanceApp.Pages;

public partial class Food : ContentPage
{
	public Food()
	{
		InitializeComponent();
	}
    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
    private async void OnAddExpensesClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddExpenses());
    }
}