using Mopups.Services;

namespace FinanceApp.Pages;

public partial class DeleteAccount : ContentPage
{
	public DeleteAccount()
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
    private async void OnCancel(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Setting());
    }
    private async void OnDelete(object sender, EventArgs e)
    {
        await MopupService.Instance.PushAsync(new DeleteAccountPopup());
    }
}