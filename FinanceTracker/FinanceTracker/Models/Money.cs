using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Models
{
    internal class Money
    {
        public List<TransactionHistory> History { get; private set; }
        public decimal Balance { get; internal set {
                if(field - value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }
                field = value;
            }
        }

        public void DoTransaction(decimal amount, string description)
        {
            Balance += amount;
            History.Add(new TransactionHistory(amount, description));
        }
    }
}
