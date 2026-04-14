namespace FinanceApp.Pages;

public partial class Travel : ContentPage
{
	public Travel()
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
    private async void OnSaveClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddSavings());
    }
}