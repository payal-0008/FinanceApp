using FinanceApp.Services;
namespace FinanceApp.Pages;

public partial class Login : ContentPage
{
    private readonly ApiService _api;
    public Login()
    {
        InitializeComponent();
        _api = new ApiService();
    }
    private async void SignUp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUp());
    }
    private async void forget(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ForgotPass());
    }
    private async void sign(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUp());
    }
    private async void fingerprint(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecurityFingerprint());
    }
    private async void home(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EmailEntry.Text) ||
           string.IsNullOrWhiteSpace(PasswordEntry.Text))
        {
            await DisplayAlert("Error", "Please enter email and password", "OK");
            return;
        }

        Loader.IsVisible = true;
        Loader.IsRunning = true;
        LoginBtn.IsEnabled = false;
        LoginBtn.Text = "";
        await Task.Delay(150);
        //try
        //{
        //    MainThread.BeginInvokeOnMainThread(() =>
        //    {
        //        Application.Current.MainPage = new AppShell();
        //    });
        //}
        //catch (Exception ex)
        //{
        //    Loader.IsRunning = false;
        //    Loader.IsVisible = false;
        //    LoginBtn.IsEnabled = true;
        //    LoginBtn.Text = "Log In";
        //}
        try
        {
            // ✅ Call the API
            var token = await _api.LoginAsync(EmailEntry.Text, PasswordEntry.Text);

            if (token != null)
            {
                // ✅ Save token securely
                await SecureStorage.SetAsync("auth_token", token);

                // ✅ Navigate to main app
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Application.Current.MainPage = new AppShell();
                });
            }
            else
            {
                await DisplayAlert("Error", "Invalid email or password", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Connection failed: {ex.Message}", "OK");
        }
        finally
        {
            Loader.IsRunning = false;
            Loader.IsVisible = false;
            LoginBtn.IsEnabled = true;
            LoginBtn.Text = "Log In";
        }
    }

}

//namespace FinanceApp.Pages;

//public partial class Login : ContentPage
//{
//    public Login()
//    {
//        InitializeComponent();
//    }

//    private async void forget(object sender, EventArgs e)
//    {
//        await Navigation.PushAsync(new ForgotPass());
//    }
//    private async void sign(object sender, EventArgs e)
//    {
//        await Navigation.PushAsync(new SignUp());
//    }
//}