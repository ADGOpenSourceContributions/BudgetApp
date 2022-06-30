using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner3._1
{
    //Holds get and set methods
    public abstract class Expense
    {
        //Variables
        //Used in the calculation of the monthly pay
        public static double monthlyPay;
        //Used to calculate the amount after the deposit is deducted
        public static double totalPay;
        //Stores number of months and is used for calculations
        public static double numbOfMonths;
        //Stores the initial price and is used for calculations
        public static double purchasePrice;
        //Stores the total deposit and is used for calulations
        public static double totalDeposit;
        //Stores the intrerest rate amount given by the user and uses it for calculations
        public static double interestRate;
        //Stores the monthly income and uses it for caculations
        public static double income;
        //Stores the rent value and uses it for calculations
        public static double rentPay;
        //Stores all the expenses and uses them for calculations
        public static List<double> expensesNumb = new List<double>();
        //Stores the insuracne premium and uses it for calculations
        public static double insurancePremium;
        //Stores the reasons and uses it for outputting
        public static string reason;
        //Stores the make and model of a car for the Car page
        public static string make;
        //Stores the specific amount used in calculations for a savings account
        public static double specifiedAmt;

        //Gets and sets for the variables
        public double MonthlyPay { get => monthlyPay; set => monthlyPay = value; }
        public double NumbOfMonths { get => numbOfMonths; set => numbOfMonths = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double TotalDeposit { get => totalDeposit; set => totalDeposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double TotalPay { get => totalPay; set => totalPay = value; }
        public double Income { get => income; set => income = value; }
        public double RentPay { get => rentPay; set => rentPay = value; }
        public double InsurancePremium { get => insurancePremium; set => insurancePremium = value; }
        public string Reason { get => reason; set => reason = value; }
        public double SpecifiedAmt { get => specifiedAmt; set => specifiedAmt = value; }
        public string Make { get => make; set => make = value; }
        public List<double> ExpensesNumb { get => expensesNumb; set => expensesNumb = value; }
    }
}
