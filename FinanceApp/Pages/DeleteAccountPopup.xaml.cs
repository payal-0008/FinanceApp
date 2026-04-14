using Mopups.Services;

namespace FinanceApp.Pages;

public partial class DeleteAccountPopup : Mopups.Pages.PopupPage
{
    public DeleteAccountPopup()
    {
        InitializeComponent();
    }

    private async void OnConfirmDeleteClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAllAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }
}