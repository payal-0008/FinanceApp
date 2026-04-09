namespace FinanceApp.Pages;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}
	private async void login(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new Login());
	}
	private async void home(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new Dashboard());
	}
}