using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.ViewModels
{
    using FinanceApp.Models;
    using FinanceApp.Pages;
    using FinanceApp.Services;
    using System.Windows.Input;

    public class RegisterViewModel : BindableObject
    {
        private readonly ApiService _authService;

        public RegisterViewModel()
        {
            _authService = new ApiService();
            RegisterCommand = new Command(async () => await Register());
        }

        // 🔹 Bind properties
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }

        public ICommand RegisterCommand { get; }

        private async Task Register()
        {
            try
            {
                var model = new RegisterModel
                {
                    FullName = FullName,
                    Email = Email,
                    Mobile = Mobile,
                    DateOfBirth = DateOfBirth,
                    Password = Password
                };

                var result = await _authService.Register(model);

                await Application.Current.MainPage.DisplayAlert("Success", result, "OK");
                Application.Current.MainPage = new Login(); 
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
