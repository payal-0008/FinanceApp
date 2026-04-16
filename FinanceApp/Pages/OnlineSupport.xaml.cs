using FinanceApp.Models;
using System.Collections.ObjectModel;

namespace FinanceApp.Pages;

public partial class OnlineSupport : ContentPage
{
    public ObservableCollection<ChatItem> EndedChats { get; set; } = new();

    public OnlineSupport()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        var chats = new List<ChatItem>
        {
            new ChatItem { Title = "Help Center", Message = "Your account is ready to use...", Date = "Feb 08 - 2024" },
            new ChatItem { Title = "Support Assistant", Message = "Hello! I'm here to assist you", Date = "Dec 24 - 2023" },
            new ChatItem { Title = "Support Assistant", Message = "Hello! I'm here to assist you", Date = "Sep 10 - 2023" },
            new ChatItem { Title = "Help Center", Message = "Hi, how are you today?", Date = "June 12 - 2023" }
        };

        foreach (var chat in chats)
            EndedChats.Add(chat);

        EndedChatsCollection.ItemsSource = EndedChats;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();

    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());

    private async void OnStartChat(object sender, EventArgs e)
    {
        await DisplayAlert("Support", "Connecting to a new assistant...", "OK");
    }
}