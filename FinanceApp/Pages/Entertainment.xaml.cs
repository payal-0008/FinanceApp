using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Entertainment : ContentPage
{
    public ObservableCollection<EntHistoryGroup> GroupedEntData { get; set; } = new();

    public Entertainment()
    {
        InitializeComponent();
        LoadEntData();
    }

    private void LoadEntData()
    {
        // April Data
        var aprilItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Cinema", Date = "20:15 - April 29", Amount = "-$30,00", Icon = "video.png" },
            new TransactionModel { Name = "Netflix", Date = "16:15 - April 12", Amount = "-$12,27", Icon = "video.png" },
            new TransactionModel { Name = "Karaoke", Date = "18:00 - April 05", Amount = "-$10,00", Icon = "video.png" }
        };

        // March Data
        var marchItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Video Game", Date = "20:50 - March 24", Amount = "-$60,20", Icon = "video.png" },
            new TransactionModel { Name = "Netflix", Date = "16:15 - March 12", Amount = "-$12,27", Icon = "video.png" }
        };

        GroupedEntData.Clear();
        GroupedEntData.Add(new EntHistoryGroup("April", aprilItems));
        GroupedEntData.Add(new EntHistoryGroup("March", marchItems));

        EntList.ItemsSource = GroupedEntData;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();
    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
    private async void OnAddExpensesClick(object sender, EventArgs e) => await Navigation.PushAsync(new AddExpenses());
}