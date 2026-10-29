using FinanceTracker.Models;
namespace FinanceTracker.Views;

public partial class MoneyAndTransactionView : ContentView
{
	public MoneyAndTransactionView(Money money)
	{
		InitializeComponent();
		BindingContext = money;
	}
}