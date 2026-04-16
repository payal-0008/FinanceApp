using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Car : ContentPage
{
    public ObservableCollection<EntHistoryGroup> GroupedCarData { get; set; } = new();

    public Car()
    {
        InitializeComponent();
        LoadCarData();
    }

    private void LoadCarData()
    {
        // July Data
        var julyItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Car Deposit", Date = "14:16 - July 05", Amount = "$387.32", Icon = "car.png" }
        };

        // May Data
        var mayItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Car Deposit", Date = "21:45 - May 30", Amount = "$122.99", Icon = "car.png" },
            new TransactionModel { Name = "Car Deposit", Date = "14:25 - May 05", Amount = "$85.94", Icon = "car.png" }
        };

        GroupedCarData.Clear();
        GroupedCarData.Add(new EntHistoryGroup("July", julyItems));
        GroupedCarData.Add(new EntHistoryGroup("May", mayItems));

        CarHistoryList.ItemsSource = GroupedCarData;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();
    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
    private async void OnSaveClick(object sender, EventArgs e) => await Navigation.PushAsync(new AddSavings());
}