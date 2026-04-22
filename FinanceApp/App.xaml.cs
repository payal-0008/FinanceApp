using FinanceApp.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();

        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new NavigationPage(new Login()));
        //}
    }
}