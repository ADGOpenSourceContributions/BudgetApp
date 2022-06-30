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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings
    {
        //Object for calling another class
        SavingsCalculations save = new SavingsCalculations();

        //Method for error message
        public void error()
        {
            //Error message that displays when the user has made an error
            MessageBox.Show("An error has occured!\nPlease refer to textbox highlighted in red!\nMake sure the value enetered is correct and try again.");
        }

        //Method for the window
        public Savings()
        {
            InitializeComponent();
        }

        //Method for the savings button
        public void savingsEnterBtn_Click(object sender, RoutedEventArgs e)
        {
            //Boolean variable used in error handling
            Boolean savingsValidation = true;

            //Message box that displays message informing user that their values were entered
            MessageBox.Show("Your values have been entered correctly!");
            
            //Calls variable from the class and defines the varible
            save.Reason = reasonTB.Text;
            
            try
            {
            //Calls variable from the class and defines it
            save.SpecifiedAmt = double.Parse(amountTB.Text);
            }
            catch (Exception)
            {
                //Boolean value for if there was an error
                savingsValidation = false;
                //Displays error message
                error();
                //Changes color of backround of the textbox
                reasonTB.Background = Brushes.Red;
                //Changes color of the font of the textbox
                reasonTB.Foreground = Brushes.White;
                //Clears the textbox
                reasonTB.Clear();
            }

            try
            {
            save.InterestRate = double.Parse(savingsInterestTB.Text);
            }
            catch (Exception)
            {
                savingsValidation = false;
                error();
                savingsInterestTB.Background = Brushes.Red;
                savingsInterestTB.Foreground = Brushes.White;
                savingsInterestTB.Clear();
            }

            try
            {
            save.NumbOfMonths = double.Parse(numbOfMonthsTb.Text);
            }
            catch (Exception)
            {
                savingsValidation = false;
                error();
                numbOfMonthsTb.Background = Brushes.Red;
                numbOfMonthsTb.Foreground = Brushes.White;
                numbOfMonthsTb.Clear();
            }

            //If the savingsValidation is true the next page will open
            if (savingsValidation == true)
            {
            //Creation of object for the next page
            Expenses exp = new Expenses();
            //Shows the next page for specific button press
            exp.Show();
            //Closses current page
            this.Close();
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Boolean savingsValidation = true;

            MessageBox.Show("Your values have been entered correctly!");

            save.Reason = reasonTB.Text;

            try
            {
                save.SpecifiedAmt = double.Parse(amountTB.Text);
            }
            catch (Exception)
            {
                savingsValidation = false;
                error();
                reasonTB.Background = Brushes.Red;
                reasonTB.Foreground = Brushes.White;
                reasonTB.Clear();
            }

            try
            {
                save.InterestRate = double.Parse(savingsInterestTB.Text);
            }
            catch (Exception)
            {
                savingsValidation = false;
                error();
                savingsInterestTB.Background = Brushes.Red;
                savingsInterestTB.Foreground = Brushes.White;
                savingsInterestTB.Clear();
            }

            try
            {
                save.NumbOfMonths = double.Parse(numbOfMonthsTb.Text);
            }
            catch (Exception)
            {
                savingsValidation = false;
                error();
                numbOfMonthsTb.Background = Brushes.Red;
                numbOfMonthsTb.Foreground = Brushes.White;
                numbOfMonthsTb.Clear();
            }

            if (savingsValidation == true)
            {
            carPage cp = new carPage();
            cp.Show();
            this.Close();
            }
        }
    }
}
