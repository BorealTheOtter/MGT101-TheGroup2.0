using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Models
{
    public class Money
    {
        public List<TransactionHistory> History { get; set; }
        public decimal Balance { get; set;}

        public void DoTransaction(decimal amount, string description)
        {
            if (History == null)  History = new List<TransactionHistory>();
            History.Add(new TransactionHistory(amount, Balance, Balance + amount, description));
            Balance += amount;
        }
    }
}
