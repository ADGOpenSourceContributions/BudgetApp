using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner3._1
{
    //This class extends the Expense class
    class CarLoan : Expense
    {

        //Method for calculating the monthly repayment for a car
        public double monthlyCarRepayment()
        {
            //Calculation of the monthly payment for the car
            totalPay = ((purchasePrice - totalDeposit) + ((purchasePrice - totalDeposit) * interestRate/100)) / 60;
            monthlyPay = totalPay + insurancePremium;
            return monthlyPay;
        }

    }
}