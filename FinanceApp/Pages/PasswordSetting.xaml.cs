namespace FinanceApp.Pages;

public partial class PasswordSetting : ContentPage
{
	public PasswordSetting()
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
    private async void ChngePass(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PassSuccessfull());
    }
}