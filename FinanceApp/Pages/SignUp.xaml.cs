namespace FinanceApp.Pages;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}
	private async void login(object sender,EventArgs e)
	{
		await Navigation.PushAsync(new Login());
	}
	private async void home(object sender,EventArgs e)
    { 
    SignUpBtn.IsEnabled = false;
    SignUpBtn.Text = "";

   
    SignUpLoader.IsVisible = true;
    SignUpLoader.IsRunning = true;
		await Task.Delay(150);

    try 
    {
        MainThread.BeginInvokeOnMainThread(async ( ) =>

        {
           await Navigation.PushAsync(new Login());
        });
    }
    catch (Exception ex)
    {
    SignUpLoader.IsRunning = false;
    SignUpLoader.IsVisible = false;
    SignUpBtn.IsEnabled = true;
    SignUpBtn.Text = "Sign Up";
}
	}
}