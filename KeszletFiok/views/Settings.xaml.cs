using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

namespace KeszletFiok;

public partial class Settings : ContentPage
{
	private IRepository repository;
	private Ilogic logic;
	public Settings()
	{
		InitializeComponent();
		repository = new Repository();
		logic = new Logic(repository);
	}

    private async void btnMentes_Clicked(object sender, EventArgs e)
    {
        
        try
		{
            if (inputAccount.Text != null && inputFirst.Text != null)
            {
                logic.Update("account", inputAccount.Text);
                logic.Update("firstStorage", inputFirst.Text);
                Shell.Current.GoToAsync("..");
            }
        }
		catch (Exception ex)
		{
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            await Toast.Make(ex.Message,
                  ToastDuration.Long,
                  16)
            .Show(cancellationTokenSource.Token);
        }
    }
}