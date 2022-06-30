using BudgetApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BudgetPlanner3._1
{
    /// <summary>
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
        //Creations of objects used for diplaying
        HomeLoan hl = new HomeLoan();
        CarLoan cl = new CarLoan();
        SavingsCalculations sc = new SavingsCalculations();
        public delegate string expenseExceedingDelegate(string exceedNotification);

            //Variables
            string house = null;
            double housePay = 0;
            string car = null;
            double carPay = 0;
            string savings = null;
            double savingsPay = 0;
            double totalBalance;        
        
        //Method for the window
        public Expenses()
        {
            InitializeComponent();



            //If and else statement for choosing if home loan or rent pay should be displayed
            if (hl.RentPay > 0)
            {
                //If rent is greater than 0 the rent message is displaed
                house = "\n\nYour monthly rent payment is : " + hl.RentPay.ToString("C") ;
                //Gives the housePay variable a vaue
                housePay = hl.incomeAfterRent();
            }
            else if (hl.monthlyRepayment() > 0)
            {
                //If home loan is greater than 0 then the home loan is displayed
                house = "\n\nYour monthly home loan repayment is : " + hl.monthlyRepayment().ToString("C");
                //Gives the housePay variable a value
                housePay = hl.incomeAfterHousing();
            }

            //If statement for if the value is greater than 0
            if (cl.monthlyCarRepayment() > 0)
            {
                //This will display the car message if the car repayment value is greater than 0
                car = "\n\nYour monthly car repayment for your : " +cl.Make +" will be : " + cl.monthlyCarRepayment().ToString("C");
                //Gives the carPay variable a value
                carPay = cl.monthlyCarRepayment();
            }

            //If statement for if the value is greater than 0
            if (sc.save() > 0)
            {
                //This will display the savings message if the value of the monthly savings payment is greater than 0
                savings = "\n\nYour monthly savings payment for reason : " +sc.Reason +" will be : " + sc.save().ToString("C");
                //Gives the savingsPay variable a value
                savingsPay = sc.save();
            }

            //Caculates the total balance
            totalBalance = housePay - carPay - savingsPay;

            //Displays the following in a textblock
            expensesTextBlock.Text = "Your gross monthly income : " + totalBalance.ToString("C")
                                     +"\n\nThis is your monthly expenditure : " +hl.ExpensesNumb.Sum().ToString("C")
                                     +house
                                     +car
                                     +savings;
        }

        static void delegateMethod()
        {
            expenseExceedingDelegate eed = (exceedNotificaton) => { return exceedNotificaton; };
            //Outputs a message
            MessageBox.Show(eed("Warning!!!\nYou have exceeded more than 75% of your monthly earnings!"));
        }

        //Method for when button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (totalBalance <= 0.75 * hl.Income)
            {   delegateMethod();   }
            //Closes the window
            this.Close();
        }
    }
}
