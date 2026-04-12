namespace FinanceApp.Pages;

public partial class Profile : ContentPage
{
	public Profile()
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
    private async void OnEditProfileClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditProfile());
    }
    private async void OnSecurityClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Security());
    }
}