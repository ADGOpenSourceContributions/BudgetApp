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
    /// Interaction logic for BuyHouse.xaml
    /// </summary>
    public partial class BuyHouse : Window
    {
        //Creation of object for HomeLoan class so variables can be called
        HomeLoan hl = new HomeLoan();
        
        //Method for the window
        public BuyHouse()
        {
            InitializeComponent();
        }

        //Method for error message
        public void error()
        {
            //The error message that shall display in a textbox
            MessageBox.Show("An error has occured! \nPlease refer to the textblock highlighted in red and enter a correct value and retry!");
        }

        //Class for if the button was clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Boolean value for error handling
            Boolean buyValid = true;

            //Message box telling users that their values were entered
            MessageBox.Show("Values have been entered!");

            //Try catch exception handling
            try
            {
            //Calls variable from home loan class and gives it a value which can be used for calculations in the home loan class
            hl.PurchasePrice = double.Parse(housePriceTB.Text);
            }
            catch (Exception)
            {
                //Displays the error message
                error();
                //Changes font color of the textbox
                housePriceTB.Foreground = Brushes.White;
                //Changes the textbox color
                housePriceTB.Background = Brushes.Red;
                //Clears the textbox
                housePriceTB.Clear();
                //Registers the boolean value as false so the next page will not be shown
                buyValid = false;
            }

            try
            {
            hl.TotalDeposit = double.Parse(houseDepositTB.Text);
            }
            catch (Exception)
            {
                error();
                houseDepositTB.Foreground = Brushes.White;
                houseDepositTB.Background = Brushes.Red;
                houseDepositTB.Clear();
                buyValid = false;
            }

            try
            {
            hl.InterestRate = double.Parse(houseInterestTB.Text);
            }
            catch (Exception)
            {
                error();
                houseInterestTB.Foreground = Brushes.White;
                houseInterestTB.Background = Brushes.Red;
                houseInterestTB.Clear();
                buyValid = false;
            }

            try
            {
            hl.NumbOfMonths = double.Parse(houseMonthsTB.Text);
            }
            catch (Exception)
            {
                error();
                houseMonthsTB.Foreground = Brushes.White;
                houseMonthsTB.Background = Brushes.Red;
                houseMonthsTB.Clear();
                buyValid = false;
            }

            //If statement for if the monthly repayment is greater than a third of the users income
            if (hl.incomeAfterExpenses() / 3 <= hl.monthlyRepayment())
            {
                //The following message will be displayed telling the user what had gone wrong
                MessageBox.Show("The values you have entered are invalid as the monthly home loan repayment is greater than a third of your salary please make the correct adjustments in order to fix this issue");
                //Clears the following textboxes
                housePriceTB.Clear();
                houseDepositTB.Clear();
                houseInterestTB.Clear();
                houseMonthsTB.Clear();
                //Resets the variables to the default 0
                hl.PurchasePrice.Equals(0);
                hl.TotalDeposit.Equals(0);
                hl.InterestRate.Equals(0);
                hl.NumbOfMonths.Equals(0);
                //Keeps the page from closing
                buyValid = false;
            }

            //If statement for if the boolean value is true
            if (buyValid == true)
            {
                //Object of the next page
                ChooseCar cc = new ChooseCar();
                //Shows the next page
                cc.Show();
                //Closes the current page
                this.Close();
            }
        }
    }
}
