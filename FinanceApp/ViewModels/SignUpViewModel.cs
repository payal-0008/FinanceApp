using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FinanceApp.Services;

namespace FinanceApp.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        private readonly ApiService _api;

        private string _fullName = string.Empty;
        private string _email = string.Empty;
        private string _mobile = string.Empty;
        private string _dob = string.Empty;
        private string _password = string.Empty;
        private string _confirmPassword = string.Empty;

        public string FullName
        {
            get => _fullName;
            set { _fullName = value; OnPropertyChanged(); }
        }
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }
        public string Mobile
        {
            get => _mobile;
            set { _mobile = value; OnPropertyChanged(); }
        }
        public string Dob
        {
            get => _dob;
            set { _dob = value; OnPropertyChanged(); }
        }
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }
        public string ConfirmPassword
        {
            get => _confirmPassword;
            set { _confirmPassword = value; OnPropertyChanged(); }
        }

        public ICommand SignUpCommand { get; }
        public ICommand GoToLoginCommand { get; }

        public SignUpViewModel()
        {
            _api = new ApiService();
            SignUpCommand = new Command(async () => await SignUpAsync());
            GoToLoginCommand = new Command(async () =>
                await Application.Current!.MainPage!
                    .Navigation.PushAsync(new Pages.Login()));
        }

        private async Task SignUpAsync()
        {
            if (string.IsNullOrWhiteSpace(FullName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Mobile) ||
                string.IsNullOrWhiteSpace(Dob) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                await Application.Current!.MainPage!
                    .DisplayAlert("Error", "Please fill all fields", "OK");
                return;
            }

            if (Password != ConfirmPassword)
            {
                await Application.Current!.MainPage!
                    .DisplayAlert("Error", "Passwords do not match", "OK");
                return;
            }

            IsBusy = true;

            try
            {
                //var success = await _api.RegisterAsync(
                //    FullName, Email, Mobile, Dob, Password);

                //if (success)
                //{
                //    await Application.Current!.MainPage!
                //        .DisplayAlert("Success",
                //            "Account created! Please login.", "OK");
                //    await Application.Current!.MainPage!
                //        .Navigation.PushAsync(new Pages.Login());
                //}
                //else
                //{
                //    await Application.Current!.MainPage!
                //        .DisplayAlert("Error",
                //            "Email already exists.", "OK");
                //}
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
