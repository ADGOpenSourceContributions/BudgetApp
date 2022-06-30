using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetPlanner3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Method for the window
        public MainWindow()
        {
            InitializeComponent();
        }

        //Method for the button to take user to the next page 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Creation of an object for the next page
            incomeExpense ie = new incomeExpense();
            //Shows the next page
            ie.Show();
            //Closes this page
            this.Close();
        }
    }
}
