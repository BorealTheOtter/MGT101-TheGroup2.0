using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FinanceTracker.Models
{
    public class Money
    {
        public ObservableCollection<TransactionHistory> History { get; set; }
        public ObservableCollection<Goal> Goals { get; set; }
        public decimal Balance { get; set;}

        public void DoTransaction(decimal amount, string description)
        {
            if (History == null)  History = new ObservableCollection<TransactionHistory>();
            History.Add(new TransactionHistory(amount, Balance, Balance + amount, description));
            Balance += amount;
        }

        public void AddGoal(string desc, decimal amount, int interval)
        {
            if(Goals == null) Goals = new ObservableCollection<Goal>();
            if (interval > 0) Goals.Add(new Goal(desc, amount, interval, false));
        }
    }
}
