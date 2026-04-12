namespace FinanceApp.Pages;

public partial class Security : ContentPage
{
	public Security()
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
    private async void OnChangePasswordClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChangePin());
    }
    private async void OnChangeFingerClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FingerPrint());
    }
    private async void OnTermsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TermsCondition());
    }
}