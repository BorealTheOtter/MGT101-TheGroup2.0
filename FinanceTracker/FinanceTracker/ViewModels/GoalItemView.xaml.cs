using FinanceTracker.Models;
using FinanceTracker.Views;

namespace FinanceTracker.ViewModels;

public partial class GoalItemView : ContentView
{
    private Money money;
    private Goal goal;
    private MoneyAndTransactionView mainPage;
	public GoalItemView(Goal goal, Money money, MoneyAndTransactionView view)
	{
		InitializeComponent();
        this.goal = goal;
		BindingContext = goal;
        this.money = money;
        this.mainPage = view;
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        money.DeleteGoal(goal);
        mainPage.DeleteGoalVisual(this);
    }
}