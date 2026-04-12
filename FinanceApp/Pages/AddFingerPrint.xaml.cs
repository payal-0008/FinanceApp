namespace FinanceApp.Pages;

public partial class AddFingerPrint : ContentPage
{
	public AddFingerPrint()
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
    private async void addfingerprint(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FingerprintSuccessfull());
    }
}