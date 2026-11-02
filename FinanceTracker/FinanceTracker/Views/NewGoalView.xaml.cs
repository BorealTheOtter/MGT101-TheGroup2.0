using System.Diagnostics;

namespace FinanceTracker.Views;

public partial class NewGoalView : ContentView
{
	private MainPage mainPage;
	public NewGoalView(MainPage mainPage)
	{
		InitializeComponent();
		this.mainPage = mainPage;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		decimal amount;
		bool success = decimal.TryParse(Amount.Text, out amount);

		if (!success)
		{
            Debug.WriteLine("Not a valid number, aborting");
            mainPage.DisplayAlert("Error", "Please input a valid Number", "OK");
            return;
        }

		int interval;
		success = int.TryParse(Interval.Text, out interval);
		if(!success || interval < 1)
		{
            Debug.WriteLine("Not a valid number, aborting");
            mainPage.DisplayAlert("Error", "Please input a valid whole number above 0", "OK");
            return;
        }

		mainPage.NewGoal_Done(Desc.Text, interval, amount);
    }
}