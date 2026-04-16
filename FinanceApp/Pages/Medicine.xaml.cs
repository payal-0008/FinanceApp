using System.Collections.ObjectModel;
using FinanceApp.Models;

namespace FinanceApp.Pages;

public partial class Medicine : ContentPage
{
    public ObservableCollection<MedicineHistoryGroup> GroupedMedicineData { get; set; } = new();

    public Medicine()
    {
        InitializeComponent();
        LoadMedicineData();
    }

    private void LoadMedicineData()
    {
        // April Data
        var aprilItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Acetaminophen", Date = "12:11 - April 30", Amount = "-$2,00", Icon = "medicine.png" }
        };

        // March Data
        var marchItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Vitamin C", Date = "12:30 - March 20", Amount = "-$8,20", Icon = "medicine.png" },
            new TransactionModel { Name = "Muscle Pain Cream", Date = "9:30 - March 12", Amount = "-$10,13", Icon = "medicine.png" }
        };

        // February Data
        var febItems = new List<TransactionModel>
        {
            new TransactionModel { Name = "Aspirin", Date = "19:30 - February 02", Amount = "-$2,20", Icon = "medicine.png" }
        };

        GroupedMedicineData.Clear();
        GroupedMedicineData.Add(new MedicineHistoryGroup("April", aprilItems));
        GroupedMedicineData.Add(new MedicineHistoryGroup("March", marchItems));
        GroupedMedicineData.Add(new MedicineHistoryGroup("February", febItems));

        MedicineList.ItemsSource = GroupedMedicineData;
    }

    private async void Back(object sender, EventArgs e) => await Navigation.PopAsync();
    private async void notification(object sender, EventArgs e) => await Navigation.PushAsync(new Notification());
    private async void OnAddExpensesClick(object sender, EventArgs e) => await Navigation.PushAsync(new AddExpenses());
}