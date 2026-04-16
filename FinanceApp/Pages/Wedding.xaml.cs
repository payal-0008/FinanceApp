using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Wedding : ContentPage
{
    public ObservableCollection<EntHistoryGroup> GroupedWeddingData { get; set; } = new();

    public Wedding()
    {
        InitializeComponent();
        LoadWeddingData();
    }

    private void LoadWeddingData()
    {
        // November Data
        var novemberItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Wedding Deposit", Date = "18:46 - Nov 15", Amount = "$87.32", Icon = "wedding_rings.png" }
        };

        // September Data
        var septemberItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Wedding Deposit", Date = "21:45 - Sept 30", Amount = "$22.99", Icon = "wedding_rings.png" },
            new TransactionModel { Name = "Wedding Deposit", Date = "12:25 - Sept 05", Amount = "$185.94", Icon = "wedding_rings.png" }
        };

        GroupedWeddingData.Clear();
        GroupedWeddingData.Add(new EntHistoryGroup("November", novemberItems));
        GroupedWeddingData.Add(new EntHistoryGroup("September", septemberItems));

        WeddingHistoryList.ItemsSource = GroupedWeddingData;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();
    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
    private async void OnSaveClick(object sender, EventArgs e) => await Navigation.PushAsync(new AddSavings());
}