namespace FinanceApp.Pages;

public partial class NewHouse : ContentPage
{
	public NewHouse()
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