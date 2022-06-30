using BudgetApp;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ChooseCar.xaml
    /// </summary>
    public partial class ChooseCar : Window
    {
        //Method for the window
        public ChooseCar()
        {
            InitializeComponent();

            //Creation of an object of the class
            HomeLoan hl = new HomeLoan();

            //String variable value used in displaying a summary.
            string houseChooseCar = null;

            //If else statement for what statements should be put into the houseChooseCar string
            if (hl.RentPay > 0)
            {
                //Gives the variable a message output for if the rent is greater than 0
                houseChooseCar = "Your monthly rent payment is : " + hl.RentPay.ToString("C")
                                +"\n\nYour monthly income balance is : " + hl.incomeAfterRent().ToString("C");
            }
            else if (hl.monthlyRepayment() > 0)
            {   
                //Gives the varible a message output for if the home loan repayment is greater than 0
                houseChooseCar = "Your monthly home loan repayment is : " + hl.monthlyRepayment().ToString("C")
                                +"\n\nYour monthly income balance is : " + hl.incomeAfterHousing().ToString("C");
            }

            //Outputs a messsage in the textbox
            chooseCarTextBlock.Text = "Your monthly income before your housing deductions is : " + hl.incomeAfterExpenses().ToString("C")
                + "\n\n" +houseChooseCar;
        }

        //Method for the button to bring up a specific page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Creates an object of the class
            carPage cp = new carPage();
            //Shows the next window 
            cp.Show();
            //Closes the current window
            this.Close();
        }

        private void expensesBtn_Click(object sender, RoutedEventArgs e)
        {
            Expenses ex = new Expenses();
            ex.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Savings sa = new Savings();
            sa.Show();
            this.Close();
        }
    }
}
