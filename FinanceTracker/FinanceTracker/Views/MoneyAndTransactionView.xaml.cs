using FinanceTracker.Models;
using FinanceTracker.ViewModels;
namespace FinanceTracker.Views;

public partial class MoneyAndTransactionView : ContentView
{
	public MoneyAndTransactionView(Money money)
	{
		InitializeComponent();
		BindingContext = money;

        foreach (TransactionHistory transaction in money.History)
        {
            TransactionHistoryHolder.Children.Add(new TransactionItemView(transaction));
        }

        if(money.Goals != null)
        {
            foreach (Goal goal in money.Goals)
            {
                GoalHolder.Children.Add(new GoalItemView(goal));
            }
        }
    }
}