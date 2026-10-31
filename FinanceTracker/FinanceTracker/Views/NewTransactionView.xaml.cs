using System.Diagnostics;

namespace FinanceTracker.Views;

public partial class NewTransactionView : ContentView
{
	private MainPage mainPage;
	public NewTransactionView(MainPage mainPage)
	{
		InitializeComponent();
		this.mainPage = mainPage;
	}

    private void WithdrawButton_Clicked(object sender, EventArgs e)
    {
        decimal amountInput;
        if (!decimal.TryParse(amount.Text, out amountInput))
        {
            Debug.WriteLine("Not a valid number, aborting");
            mainPage.DisplayAlert("Error", "Please input a valid Number", "OK");
            return;
        }

        mainPage.NewTransaction_Done((Math.Abs(amountInput)) * -1, desc.Text);
    }

    private void DepositButton_Clicked(object sender, EventArgs e)
    {
        decimal amountInput;
        if(!decimal.TryParse(amount.Text, out amountInput))
        {
            Debug.WriteLine("Not a valid number, aborting");
            mainPage.DisplayAlert("Error", "Please input a valid Number", "OK");
            return;
        }

        mainPage.NewTransaction_Done(Math.Abs(amountInput), desc.Text);
    }
}