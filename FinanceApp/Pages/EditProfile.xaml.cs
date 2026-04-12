namespace FinanceApp.Pages;

public partial class EditProfile : ContentPage
{
	public EditProfile()
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
    private async void updateprofile(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Profile());
    }
}