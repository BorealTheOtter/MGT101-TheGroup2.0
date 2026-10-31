using FinanceTracker.Models;

namespace FinanceTracker.Views;

public partial class TransactionItemView : ContentView
{

	public TransactionItemView(TransactionHistory transaction)
	{
		InitializeComponent();
        BindingContext = transaction;
    }
}