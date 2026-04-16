namespace FinanceApp.Pages;

public partial class Analysis : ContentPage
{
	public Analysis()
	{
		InitializeComponent();
	}
    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}