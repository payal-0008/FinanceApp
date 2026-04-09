namespace FinanceApp.Pages;

public partial class Notification : ContentPage
{
	public Notification()
	{
		InitializeComponent();
	}
	private async void Back(object sender,EventArgs e)
	{
		await Navigation.PopAsync();
	}
}