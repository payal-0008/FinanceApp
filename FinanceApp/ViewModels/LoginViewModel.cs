using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FinanceApp.Services;


namespace FinanceApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly ApiService _api;

        private string _email = string.Empty;
        private string _password = string.Empty;

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }
        public ICommand GoToSignUpCommand { get; }
        public ICommand GoToForgotPassCommand { get; }
        public ICommand GoToFingerprintCommand { get; }

        public LoginViewModel()
        {
            _api = new ApiService();
            LoginCommand = new Command(async () => await LoginAsync());
            GoToSignUpCommand = new Command(async () =>
                await GoToPage(new Pages.SignUp()));
            GoToForgotPassCommand = new Command(async () =>
                await GoToPage(new Pages.ForgotPass()));
            GoToFingerprintCommand = new Command(async () =>
                await GoToPage(new Pages.SecurityFingerprint()));
        }

        private async Task GoToPage(Page page)
        {
            await Application.Current!.MainPage!
                .Navigation.PushAsync(page);
        }

        private async Task LoginAsync()
        {
            if (string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password))
            {
                await Application.Current!.MainPage!
                    .DisplayAlert("Error",
                        "Please enter email and password", "OK");
                return;
            }

            IsBusy = true;

            try
            {
                var token = await _api.LoginAsync(Email, Password);

                if (token != null)
                {
                    await SecureStorage.SetAsync("auth_token", token);
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Application.Current!.MainPage = new AppShell();
                    });
                }
                else
                {
                    await Application.Current!.MainPage!
                        .DisplayAlert("Error",
                            "Invalid email or password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current!.MainPage!
                    .DisplayAlert("Error",
                        $"Connection failed: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
