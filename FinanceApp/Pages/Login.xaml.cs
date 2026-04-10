namespace FinanceApp.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
	private async void SignUp(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new SignUp());
	}
	private async void forget(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new ForgotPass());
	}
	private async void sign(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new SignUp());
	}
	private async void fingerprint(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new SecurityFingerprint());
	}
	private async void home(object sender,EventArgs e)
	{
        Loader.IsVisible = true;
        Loader.IsRunning = true;
        LoginBtn.IsEnabled = false;
        LoginBtn.Text = "";
        await Task.Delay(150);
        try
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Application.Current.MainPage = new AppShell();
            });
        }
        catch (Exception ex)
        {
            Loader.IsRunning = false;
            Loader.IsVisible = false;
            LoginBtn.IsEnabled = true;
            LoginBtn.Text = "Log In";
        }
    }

}