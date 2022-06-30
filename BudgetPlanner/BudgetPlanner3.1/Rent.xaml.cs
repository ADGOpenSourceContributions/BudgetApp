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
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        //Creation of an object so variables can be called from the selected class
        HomeLoan hl = new HomeLoan();

        //Class for the window
        public Rent()
        {
            InitializeComponent();
        }

        //Class for when the button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Displays message box to tell user that the values were entered.
            MessageBox.Show("The value has been entered correctly.");

            //Boolean variable for determining if the next page can be shown.
            Boolean rentPageValid = true;

            //Try catch statement for exception handling
            try
            {
                //Calling of variable and giving it a value to store
                hl.RentPay = double.Parse(rentTB.Text);
            }
            catch (Exception)
            {
                //Value of the boolean will send user back to re enter the value
                rentPageValid = false;
                //Message box to show error information
                MessageBox.Show("An error has occured!\nPlease refer to textbox highlighted in red!\nMake sure the value enetered is correct and try again.");
                //Clears the textbox
                rentTB.Clear();
                //Changes color of font for textbox
                rentTB.Foreground = Brushes.White;
                //Changes color of the  textbox
                rentTB.Background = Brushes.Red;
            }

            //If statement for error handling
            if (rentPageValid == true)
            {
            //Object of the next window
            ChooseCar cc = new ChooseCar();
            //Displays the next window
            cc.Show();
            //Closes this window
            this.Close();
            }
        }
    }
}
