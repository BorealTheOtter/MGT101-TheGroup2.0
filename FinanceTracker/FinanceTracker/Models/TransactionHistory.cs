using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Models
{
    public struct TransactionHistory
    {
        public TransactionHistory(decimal amount, decimal oldBalance,decimal newBalance, string description)
        {
            this.Amount = amount;
            this.Description = description;
            this.PreviousBalance = oldBalance;
            this.NewAmount = newBalance;
        }

        public decimal Amount { get; set; }
        public decimal PreviousBalance { get; set; }
        public decimal NewAmount { get; set; }
        public string Description { get; set; }
    }
}