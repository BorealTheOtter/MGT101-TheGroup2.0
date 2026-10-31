using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Models
{
    public class Goal
    {
        public Goal() { }

        public Goal(string desc, decimal amount, int interval, bool reached)
        {
            GoalDesc = desc;
            AmountToChange = amount;
            DayTimeInterval = interval;
            GoalReached = reached;
        }
        public string GoalDesc { get; set; }
        public decimal AmountToChange { get; set; }
        public int DayTimeInterval { get; set; }
        public bool GoalReached { get; set; }
    }
}
