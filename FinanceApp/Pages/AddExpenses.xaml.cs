using System;
using Microsoft.Maui.Controls;
namespace FinanceApp.Pages;

public partial class AddExpenses : ContentPage
{
	public AddExpenses()
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
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Expense saved successfully!", "OK");
        await Navigation.PopAsync();
    }
    private void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        if (SelectedDateLabel != null)
        {
            SelectedDateLabel.Text = $"{e.NewDate:MMMM dd, yyyy}";
        }
    }
    private async void OnSelectCategoryTapped(object sender, EventArgs e)
    {
        // Yahan tu Picker ya bottom sheet khol sakta hai
        await DisplayActionSheet("Select Category", "Cancel", null, "Food", "Transport", "Medicine", "Rent");
    }
}