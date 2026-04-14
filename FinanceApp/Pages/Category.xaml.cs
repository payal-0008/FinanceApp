using Mopups.Services;

namespace FinanceApp.Pages;

public partial class Category : ContentPage
{
	public Category()
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
    private async void OnFoodClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Food());
    }
    private async void OnTransportClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Transport());
    }
    private async void OnGroceryClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Groceries());
    }
    private async void OnRentClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Rent());
    }
    private async void OnGiftsClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Gifts());
    }
    private async void OnSavingClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Savings());
    }
    private async void OnMedicineClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Medicine());
    }
    private async void OnEntertainmentClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Entertainment());
    }
    private async void OnMoreClick(object sender, EventArgs e)
    {
        await MopupService.Instance.PushAsync(new MorePopUp());
    }
}