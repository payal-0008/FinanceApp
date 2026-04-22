using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Travel : ContentPage
{
    public ObservableCollection<TransactionModel> TravelData { get; set; } = new();

    public Travel()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        TravelData.Clear();
        TravelData.Add(new TransactionModel { Name = "Travel Deposit", Date = "19:56 - April 30", Amount = "$217.77", Icon = "aeroplanes.png" });
        TravelData.Add(new TransactionModel { Name = "Travel Deposit", Date = "17:42 - April 14", Amount = "$217.77", Icon = "aeroplanes.png" });
        TravelData.Add(new TransactionModel { Name = "Travel Deposit", Date = "12:30 - April 04", Amount = "$217.77", Icon = "aeroplanes.png" });

        TravelList.ItemsSource = TravelData;
    }

    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());

    }

    private async void OnSaveClick(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new AddSavings());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }
}