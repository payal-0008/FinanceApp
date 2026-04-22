namespace FinanceApp.Pages;

public partial class Calender : ContentPage
{
	public Calender()
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