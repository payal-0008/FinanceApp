namespace FinanceApp.Pages;

public partial class Setting : ContentPage
{
	public Setting()
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
    private async void OnNotificationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotificationSetting());
    }
    private async void OnPasswordClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PasswordSetting());
    }
    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeleteAccount());
    }
}