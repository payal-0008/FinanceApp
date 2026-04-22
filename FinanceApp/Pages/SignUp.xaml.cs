using FinanceApp.Services;
using Microsoft.Extensions.Logging.Abstractions;

namespace FinanceApp.Pages;

public partial class SignUp : ContentPage
{
    private readonly ApiService _api;

    public SignUp()
    {
        InitializeComponent();
        //BindingContext = new RegisterViewModel();
        _api = new ApiService();
    }

    private async void login(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
    private async void home(object sender, EventArgs e)
    {
        // ✅ Validate all fields
        if (string.IsNullOrWhiteSpace(FullNameEntry.Text) ||
            string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(MobileEntry.Text) ||
            string.IsNullOrWhiteSpace(DobEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text))
        {
            await DisplayAlert("Error", "Please fill all fields", "OK");
            return;
        }

        // ✅ Check passwords match
        if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
        {
            await DisplayAlert("Error", "Passwords do not match", "OK");
            return;
        }

        SignUpBtn.IsEnabled = false;
        SignUpBtn.Text = "";
        SignUpLoader.IsVisible = true;
        SignUpLoader.IsRunning = true;

        //try
        //{
        //    // ✅ Call API — saves all data to DB
        //    var success = await _api.RegisterAsync(
        //        FullNameEntry.Text,
        //        EmailEntry.Text,
        //        MobileEntry.Text,
        //        DobEntry.Text,
        //        PasswordEntry.Text
        //    );

        //    if (success)
        //    {
        //        await DisplayAlert("Success", "Account created! Please login.", "OK");
        //        await Navigation.PushAsync(new Login());
        //    }
        //    else
        //    {
        //        await DisplayAlert("Error", "Registration failed. Email already exists.", "OK");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    await DisplayAlert("Error", $"Connection failed: {ex.Message}", "OK");
        //}
        //finally
        //{
        //    SignUpLoader.IsRunning = false;
        //    SignUpLoader.IsVisible = false;
        //    SignUpBtn.IsEnabled = true;
        //    SignUpBtn.Text = "Sign Up";
        //}
    }
}