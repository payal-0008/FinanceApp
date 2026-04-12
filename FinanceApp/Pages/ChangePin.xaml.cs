namespace FinanceApp.Pages;

public partial class ChangePin : ContentPage
{
	public ChangePin()
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
    private async void ChngePin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SuccessFullPin());
    }
}