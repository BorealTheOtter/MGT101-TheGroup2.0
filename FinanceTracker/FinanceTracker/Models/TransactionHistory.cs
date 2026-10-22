using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Models
{
    public struct TransactionHistory
    {
        public TransactionHistory(decimal amount, string description)
        {
            Amount = amount;
            Description = description;
        }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
