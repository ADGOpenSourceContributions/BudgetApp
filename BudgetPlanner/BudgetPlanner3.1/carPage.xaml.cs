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
    /// Interaction logic for carPage.xaml
    /// </summary>
    public partial class carPage : Window
    {
        //Creation of an object for the class
        CarLoan cl = new CarLoan();

        //Method for the current window
        public carPage()
        {
            InitializeComponent();
        }

        //Method for an error message
        public void error()
        {
            //Error message that is showed when user has made an error
            MessageBox.Show("An error has occured! \nPlease refer to the textblock highlighted in red and enter a correct value and retry!");
        }

        //Method for when the button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Boolean value that is used in error handling
            Boolean carPageValid = true;

            MessageBox.Show("Your values have been entered!");

                //Try catch error exception handling
                try
                {
                    //Calls class and gives the variable in the class a value
                    cl.Make = makeTB.Text;
                }
                catch (Exception)
                {
                    //Defines the boolean as false so next page can not be showed
                    carPageValid = false;
                    //Error message displayed
                    error();
                    //Changes font color to white in the textbox
                    makeTB.Foreground = Brushes.White;
                    //Changes the textbox color to red
                    makeTB.Background = Brushes.Red;
                    //Clears the textbox
                    makeTB.Clear();
                }

                try
                {
                    cl.PurchasePrice = double.Parse(carPurchaseTB.Text);
                }
                catch (Exception)
                {
                    carPageValid = false;
                    error();
                    carPurchaseTB.Foreground = Brushes.White;
                    carPurchaseTB.Background = Brushes.Red;
                    carPurchaseTB.Clear();
                }

                try
                {
                    cl.TotalDeposit = double.Parse(carDepositTB.Text);
                }
                catch (Exception)
                {
                    carPageValid = false;
                    error();
                    carDepositTB.Foreground = Brushes.White;
                    carDepositTB.Background = Brushes.Red;
                    carDepositTB.Clear(); 
                }

                try
                {
                    cl.InterestRate = double.Parse(carInterestTB.Text);
                }
                catch (Exception)
                {
                    carPageValid = false;
                    error();
                    carInterestTB.Foreground = Brushes.White;
                    carInterestTB.Background = Brushes.Red;
                    carInterestTB.Clear();
                }

                try
                {
                    cl.InsurancePremium = double.Parse(insuranceTB.Text);
                }
                catch (Exception)
                {
                    carPageValid = false;
                    error();
                    insuranceTB.Foreground = Brushes.White;
                    insuranceTB.Background = Brushes.Red;
                    insuranceTB.Clear();
                }

            //If statement for if the carPageValid boolean is true, will show the user the next page
            if (carPageValid == true)
            {
                //Object for the next window
                Expenses ex = new Expenses();
                //Displays the next window
                ex.Show();
                //Closes the current window
                this.Close();
            }
        }
    }
}
