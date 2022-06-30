using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner3._1
{
    class SavingsCalculations : Expense
    {
        //Method for calculating the saving payment
        public double save()
        {
            //Caculation of the monthly pay
            monthlyPay = SpecifiedAmt/numbOfMonths/(interestRate/100);
            //Returns the monthly pay
            return monthlyPay;
        }
    }
}
