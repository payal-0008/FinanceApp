namespace FinanceApp.Pages;

public partial class NewPassword : ContentPage
{
	public NewPassword()
	{
		InitializeComponent();
	}
	private async void chngepass(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new Successfull());
	}
}