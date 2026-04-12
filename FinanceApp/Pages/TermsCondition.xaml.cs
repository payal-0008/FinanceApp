namespace FinanceApp.Pages;

public partial class TermsCondition : ContentPage
{
	public TermsCondition()
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
    private async void OnAccept(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Security());
    }
}