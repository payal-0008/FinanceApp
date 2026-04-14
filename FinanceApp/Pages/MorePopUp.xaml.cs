using Mopups.Services;

namespace FinanceApp.Pages;


public partial class MorePopUp : Mopups.Pages.PopupPage
{
	public MorePopUp()
	{
		InitializeComponent();
	}
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAllAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await MopupService.Instance.PopAsync();
    }
}