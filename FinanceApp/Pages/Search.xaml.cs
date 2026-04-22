namespace FinanceApp.Pages;

public partial class Search : ContentPage
{
	public Search()
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