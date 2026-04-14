using Mopups.Services;

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
    private async void OnSettingClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Setting());
    }
    private async void OnHelpClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HelpAndFaqs());
    }
    private async void OnLogOut(object sender, EventArgs e)
    {
        await MopupService.Instance.PushAsync(new LogOut());
    }
   
}