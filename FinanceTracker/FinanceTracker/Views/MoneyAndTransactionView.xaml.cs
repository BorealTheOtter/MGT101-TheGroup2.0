using FinanceTracker.Models;
using FinanceTracker.ViewModels;
namespace FinanceTracker.Views;

public partial class MoneyAndTransactionView : ContentView
{
	public MoneyAndTransactionView(Money money)
	{
		InitializeComponent();
		BindingContext = money;

        if(money.History != null)
        {
            for (int i = money.History.Count - 1; i >= 0; i--)
            {
                TransactionHistoryHolder.Children.Add(new TransactionItemView(money.History[i]));
            }
        }

        if(money.Goals != null)
        {
            for (int i = money.Goals.Count - 1; i >= 0; i--)
            {
                GoalHolder.Children.Add(new GoalItemView(money.Goals[i], money, this));
            }
        }
    }

    public async Task DeleteGoalVisual(GoalItemView goal)
    {
        GoalHolder.Children.Remove(goal);
    }
}