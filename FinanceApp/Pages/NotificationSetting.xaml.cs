namespace FinanceApp.Pages;

public partial class NotificationSetting : ContentPage
{
	public NotificationSetting()
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
}