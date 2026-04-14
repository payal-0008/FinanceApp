using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class OnlineSupport : ContentPage
{
	public OnlineSupport()
	{
		InitializeComponent();
        List<ChatItem> endedChats = new List<ChatItem>
            {
                new ChatItem { Title = "Help Center", Message = "Your account is ready to use...", Date = "Feb 08 -2024" },
                new ChatItem { Title = "Support Assistant", Message = "Hello! I'm here to assist you", Date = "Dic 24 -2023" },
                new ChatItem { Title = "Support Assistant", Message = "Hello! I'm here to assist you", Date = "Sep 10 -2023" },
                new ChatItem { Title = "Help Center", Message = "Hi, how are you today?", Date = "June 12 -2023" }
            };

        // CollectionView ko source assign karo
        EndedChatsCollection.ItemsSource = endedChats;
    }
    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
}