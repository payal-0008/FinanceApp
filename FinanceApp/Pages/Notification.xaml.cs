using System.Collections.ObjectModel;
using FinanceApp.Models;
namespace FinanceApp.Pages;

public partial class Notification : ContentPage
{
    public ObservableCollection<NotificationModel> NotificationList { get; set; }
    public Notification()
	{
		InitializeComponent();
        NotificationList = new ObservableCollection<NotificationModel>
            {
                new NotificationModel
                {
                    Title = "Reminder!",
                    SubTitle = "Set up your automatic savings to meet your savings goal..",
                    Item = "Today",
                    Date = "17:00 - April 24",
                    Image = "bell.png"
                },
                new NotificationModel
                {
                    Title = "New Update",
                    SubTitle = "A new version of the app is available for download.",
                    Item = "Today",
                    Date = "18:30 - April 24",
                    Image = "star.png"
                },
                new NotificationModel
                {
                    Title = "Transactions",
                    SubTitle = "A new transaction has been registered",
                    Item = "Yesterday",
                    Date = "10:00 - April 23",
                    Image = "dollar_icon.png"
                },
                new NotificationModel
                {
                    Title = "Reminder!",
                    SubTitle = "Set up your automatic savings to meet your savings goal..",
                    Item = "Today",
                    Date = "17:00 - April 24",
                    Image = "bell.png"
                },
                new NotificationModel
                {
                    Title = "Expense Record",
                    SubTitle = "We recommend that you be more attentive to your finances.",
                    Item = "This Weekend",
                    Date = "09:00 - April 21",
                    Image = "down_arrows.png"
                },
                 new NotificationModel
                {
                   Title = "Transactions",
                    SubTitle = "A new transaction has been registered",
                    Item = "Yesterday",
                    Date = "10:00 - April 23",
                    Image = "dollar_icon.png"
                }
            };

        BindingContext = this;
    }

	private async void Back(object sender,EventArgs e)
	{
		await Navigation.PopAsync();
	}
}