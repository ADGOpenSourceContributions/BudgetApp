using BudgetPlanner3._1;
using System.Linq;

namespace BudgetApp
{
    //This class extends the Expense class
    public class HomeLoan : Expense
    {
        //Calculates the monthly repayment for the housing

        //Calculates the income after expenses are entered
        public double incomeAfterExpenses()
        {
            //Returns the value of the income after expenses
            return income - expensesNumb.Sum();
        }

        //Calculates the monthly repayment on a house
        public double monthlyRepayment()
        {
            //Variable for the actual price that would be paid
            double actualValue;
            //Calculation for the initial price - the deposit put in place
            totalPay = purchasePrice - totalDeposit;
            //Caclulation to calculate the actual price to be paid per month
            actualValue = totalPay * (1 + interestRate / 100 * (numbOfMonths / 12));
            //Calculates the monthly payment
            monthlyPay = actualValue / numbOfMonths;
            //Returns the monthly home loan amount
            return monthlyPay;
        }

        //Calculates the monthly icnome after home loan payment
        public double incomeAfterHousing()
        {
            //returns the balance of income - home loan repayment
            return incomeAfterExpenses() - monthlyRepayment();
        }

        //Caclulates the monthly income after rent deductions 
        public double incomeAfterRent()
        {
            //returns the balance of income - rent 
            return incomeAfterExpenses() - RentPay;
        }
    }
}