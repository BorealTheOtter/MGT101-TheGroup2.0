using FinanceTracker.Models;
using FinanceTracker.Views;

namespace FinanceTracker.ViewModels;

public partial class GoalItemView : ContentView
{
	public GoalItemView(Goal goal)
	{
		InitializeComponent();
		BindingContext = goal;
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        //TODO: Handle delete button click event
    }
}