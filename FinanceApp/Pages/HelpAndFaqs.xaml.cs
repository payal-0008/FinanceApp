using FinanceApp.Models;
using System.Collections.ObjectModel;

namespace FinanceApp.Pages;

public partial class HelpAndFaqs : ContentPage
{
    private bool _isFaqMode = true;
    public bool IsFaqMode
    {
        get => _isFaqMode;
        set
        {
            _isFaqMode = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsContactMode)); 
        }
    }
    public bool IsContactMode => !IsFaqMode;
    public ObservableCollection<FAQItem> FAQs { get; set; }
    public HelpAndFaqs()
	{
		InitializeComponent();
        BindingContext = this;
        FAQs = new ObservableCollection<FAQItem>
        {
            new FAQItem { Question = "How to use FinWise?", Answer = "Open the app, link your bank accounts or enter transactions manually to track your spending habits effortlessly." },
            new FAQItem { Question = "How much does it cost to use FinWise?", Answer = "FinWise offers a free basic version. Premium features like advanced analytics are available for a small monthly subscription." },
            new FAQItem { Question = "How to contact support?", Answer = "You can reach us via the 'Contact Us' tab or email support@finwiseapp.de directly." },
            new FAQItem { Question = "How can I reset my password if I forget it?", Answer = "Go to the login screen, click 'Forgot Password', and follow the instructions sent to your registered email." },
            new FAQItem { Question = "Is my data secure?", Answer = "Yes, we use industry-standard AES-256 encryption to ensure your financial data stays private and safe." }
        };
        FAQCollection.ItemsSource = FAQs;
    }
    private void OnFaqTabClicked(object sender, EventArgs e)
    {
        IsFaqMode = true;
    
        BtnFaq.BackgroundColor = (Color)Application.Current.Resources["MainColor"];
        BtnContact.BackgroundColor = Colors.Transparent;
    }

    private void OnContactTabClicked(object sender, EventArgs e)
    {
        IsFaqMode = false;
      
        BtnContact.BackgroundColor = (Color)Application.Current.Resources["MainColor"];
        BtnFaq.BackgroundColor = Colors.Transparent;
    }
    private void OnFAQClicked(object sender, EventArgs e)
    {
        var grid = sender as Grid;
        var item = grid?.BindingContext as FAQItem;
        if (item != null)
        {
            item.IsVisible = !item.IsVisible;
        }
    }
    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void notification(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notification());
    }
    private async void Oncustomer(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OnlineSupport());
    }
}