using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class NewHouse : ContentPage
{
    public ObservableCollection<EntHistoryGroup> GroupedHouseData { get; set; } = new();

    public NewHouse()
    {
        InitializeComponent();
        LoadHouseData();
    }

    private void LoadHouseData()
    {
        // April Data
        var aprilItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "House Deposit", Date = "19:56 - April 05", Amount = "$477.77", Icon = "home.png" }
        };

        // January Data
        var januaryItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "House Deposit", Date = "20:25 - January 16", Amount = "$102.67", Icon = "home.png" },
            new TransactionModel { Name = "House Deposit", Date = "15:56 - January 02", Amount = "$45.04", Icon = "home.png" }
        };

        GroupedHouseData.Clear();
        GroupedHouseData.Add(new EntHistoryGroup("April", aprilItems));
        GroupedHouseData.Add(new EntHistoryGroup("January", januaryItems));

        HouseHistoryList.ItemsSource = GroupedHouseData;
    }

    private async void Back(object sender, EventArgs e) { await Navigation.PopAsync(); }
    private async void notification(object sender, EventArgs e) { await Navigation.PushAsync(new Notification()); }
    private async void OnSaveClick(object sender, EventArgs e) { await Navigation.PushAsync(new AddSavings()); }
}