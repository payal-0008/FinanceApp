namespace FinanceApp.Pages;

public partial class Transaction : ContentPage
{
	public Transaction()
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
    private async void OnIncomeClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new IncomeAndExpense());
    }
}