namespace FinanceApp.Pages;

public partial class Savings : ContentPage
{
	public Savings()
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
    private async void OnTravelClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Travel());
    }
    private async void OnHouseClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewHouse());
    }
    private async void OnCarClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Car());
    }
    private async void OnWeddingClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Wedding());
    }
}