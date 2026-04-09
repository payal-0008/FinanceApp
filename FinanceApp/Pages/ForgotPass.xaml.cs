namespace FinanceApp.Pages;

public partial class ForgotPass : ContentPage
{
	public ForgotPass()
	{
		InitializeComponent();
	}
	private async void NextStep(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new SecurityPin());
	}
	private async void sign(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new SignUp());
	}
}