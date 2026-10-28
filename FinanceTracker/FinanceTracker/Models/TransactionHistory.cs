using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Models
{
    public struct TransactionHistory
    {
        public TransactionHistory(decimal amount, decimal oldBalance,decimal newBalance, string description)
        {
            this.amount = amount;
            this.Description = description;
            this.oldBalance = oldBalance;
            this.newBalanace = newBalance;
        }

        public readonly decimal amount;
        public readonly decimal oldBalance;
        public readonly decimal newBalanace;
        public string Description { get; set; }
    }
}