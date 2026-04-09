namespace FinanceApp.Pages;

public partial class SecurityPin : ContentPage
{
	public SecurityPin()
	{
		InitializeComponent();
	}
	private async void password(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new NewPassword());
	}
}