using CommunityToolkit.Maui.Views;

namespace Crypta_2._0.Views;

public partial class NewPasswordListPopup : Popup<string>
{
	public NewPasswordListPopup()
	{
		InitializeComponent();
	}

	public async void OkButton_Clicked(object sender, EventArgs e)
    {
        await CloseAsync(PasswordEntry.Text);
    }

	public async void CancelButton_Clicked(object sender, EventArgs e)
    {
        await CloseAsync(null);
    }
}