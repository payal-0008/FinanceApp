using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Gifts : ContentPage
{
    public ObservableCollection<GiftsHistoryGroup> GroupedGiftsData { get; set; } = new();

    public Gifts()
    {
        InitializeComponent();
        LoadGiftsData();
    }

    private void LoadGiftsData()
    {
        // April Data
        var aprilItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Perfume", Date = "10:30 - April 10", Amount = "-$30,00", Icon = "gift.png" },
            new TransactionModel { Name = "Snacks", Date = "18:28 - April 15", Amount = "-$60,35", Icon = "gift.png" }
        };

        // March Data
        var marchItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Teddy Bear", Date = "08:30 - March 10", Amount = "-$20,00", Icon = "gift.png" },
            new TransactionModel { Name = "Cooking Lessons", Date = "14:24 - March 02", Amount = "-$128,00", Icon = "gift.png" }
        };

        // February Data
        var febItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Toys For Dani", Date = "11:15 - February 18", Amount = "-$50,20", Icon = "gift.png" }
        };

        GroupedGiftsData.Clear();
        GroupedGiftsData.Add(new GiftsHistoryGroup("April", aprilItems));
        GroupedGiftsData.Add(new GiftsHistoryGroup("March", marchItems));
        GroupedGiftsData.Add(new GiftsHistoryGroup("February", febItems));

        GiftsList.ItemsSource = GroupedGiftsData;
    }

    private async void Back(object sender, EventArgs e) { await Navigation.PopAsync(); }
    private async void notification(object sender, EventArgs e) { await Navigation.PushAsync(new Notification()); }
    private async void OnAddExpensesClick(object sender, EventArgs e) { await Navigation.PushAsync(new AddExpenses()); }
}