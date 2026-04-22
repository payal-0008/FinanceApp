using FinanceApp.Models;
using Mopups.Services;
using System.Collections.ObjectModel;

namespace FinanceApp.Pages;

public partial class Category : ContentPage
{
    public ObservableCollection<CategoryModel> Categories { get; set; }

    public Category()
    {
        InitializeComponent();
        LoadCategories();
    }

    private void LoadCategories()
    {
        Categories = new ObservableCollection<CategoryModel>
        {
            new CategoryModel { Name = "Food", Icon = "food.png", TargetPage = "Food" },
            new CategoryModel { Name = "Transport", Icon = "car.png", TargetPage = "Transport" },
            new CategoryModel { Name = "Medicine", Icon = "medicine.png", TargetPage = "Medicine" },
            new CategoryModel { Name = "Groceries", Icon = "grocery.png", TargetPage = "Groceries" },
            new CategoryModel { Name = "Rent", Icon = "house_key.png", TargetPage = "Rent" },
            new CategoryModel { Name = "Gifts", Icon = "gift.png", TargetPage = "Gifts" },
            new CategoryModel { Name = "Savings", Icon = "money.png", TargetPage = "Savings" },
            new CategoryModel { Name = "Entertainment", Icon = "video.png", TargetPage = "Entertainment" },
            new CategoryModel { Name = "More", Icon = "sum.png", TargetPage = "More" }
        };

        CategoryList.ItemsSource = Categories;
    }

    private async void OnCategoryTapped(object sender, EventArgs e)
    {
        var layout = (VerticalStackLayout)sender;
        var gesture = (TapGestureRecognizer)layout.GestureRecognizers[0];
        var category = (CategoryModel)gesture.CommandParameter;

        if (category.Name == "More")
        {
            await MopupService.Instance.PushAsync(new MorePopUp());
            return;
        }

        Type pageType = Type.GetType($"FinanceApp.Pages.{category.TargetPage}");
        if (pageType != null)
        {
            var page = (ContentPage)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
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
}