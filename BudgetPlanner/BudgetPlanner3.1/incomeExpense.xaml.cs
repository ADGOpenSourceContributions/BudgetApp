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
    /// Interaction logic for incomeExpense.xaml
    /// </summary>
    public partial class incomeExpense : Window
    {
        //Creation of an object for the class
        HomeLoan hl = new HomeLoan();
        
        //Method for window
        public incomeExpense()
        {
            InitializeComponent();
        }

        //Method for the error message
        public void error()
        {
            //Error message that will be displayed
            rentHousebtn.IsEnabled = false;
            buyHousebtn.IsEnabled = false;
            MessageBox.Show("An error has occured! \nPlease refer to the textblock highlighted in red and enter a correct value and retry!","",MessageBoxButton.OK,MessageBoxImage.Error);
            
        }


        //Method for if the enter button is clicked
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //Message letting users know their values have been entered
            MessageBox.Show("Your values have been entered!");
            try
            {
                buyHousebtn.IsEnabled = true;
                rentHousebtn.IsEnabled = true;
                //Try catch statement error handling
                try
                {
                    //Calls class and gives variable a value
                    hl.Income = double.Parse(incomeTb.Text);
                }
                catch (Exception)
                {
                    //Error message displayed
                    error();
                    //Clears the textbox
                    incomeTb.Clear();
                    //Changes the textbox backround to red
                    incomeTb.Background = Brushes.Red;
                    //changes the textbox font to white
                    incomeTb.Foreground = Brushes.White;
                }

                try
                {
                    hl.ExpensesNumb.Add(double.Parse(taxTB.Text));
                }
                catch (Exception)
                {
                    
                    taxTB.Clear();
                    taxTB.Background = Brushes.Red;
                    taxTB.Foreground = Brushes.White;
                }

                try
                {
                    hl.ExpensesNumb.Add(double.Parse(groceriesTB.Text));
                }
                catch (Exception)
                {
                    
                    groceriesTB.Clear();
                    groceriesTB.Background = Brushes.Red;
                    groceriesTB.Foreground = Brushes.White;
                }

                try
                {
                    hl.ExpensesNumb.Add(double.Parse(waterTB.Text));
                }
                catch (Exception)
                {
                    
                    waterTB.Clear();
                    waterTB.Background = Brushes.Red;
                    waterTB.Foreground = Brushes.White;
                }

                try
                {
                    hl.ExpensesNumb.Add(double.Parse(travelTB.Text));
                }
                catch (Exception)
                {
                 
                    travelTB.Clear();
                    travelTB.Background = Brushes.Red;
                    travelTB.Foreground = Brushes.White;
                }

                try
                {
                    hl.ExpensesNumb.Add(double.Parse(cellTB.Text));
                }
                catch (Exception)
                {
                    
                    cellTB.Clear();
                    cellTB.Background = Brushes.Red;
                    cellTB.Foreground = Brushes.White;
                }

                try
                {
                    hl.ExpensesNumb.Add(double.Parse(otherTB.Text));
                }
                catch (Exception)
                {
                 
                    otherTB.Clear();
                    otherTB.Background = Brushes.Red;
                    otherTB.Foreground = Brushes.White;
                }
            }
            catch (Exception)
            {
                error();
                

            }
        }

        //Button for accessing the next page
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Creation of an object of the next page
            BuyHouse bh = new BuyHouse();
            //Shows the next page
            bh.Show();
            //Closes the current page
            this.Close();
        }

        //Button for accessing the next page
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Creation of an object of the next page
            Rent rh = new Rent();
            //Shows the next page
            rh.Show();
            //Closes the current page
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
