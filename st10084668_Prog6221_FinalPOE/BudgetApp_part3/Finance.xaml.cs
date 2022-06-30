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
using System.Windows.Shapes;

namespace BudgetApp_part3
{
    /// <summary>
    /// Interaction logic for Finance.xaml
    /// </summary>
    public partial class Finance : Window
    {
        
        public Finance()
        {
            InitializeComponent();
            
             
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Exits application
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double grossIncome = CaptureIncome(); //Method call
                Dictionary<string, double> exp = allExpenses();//Method call
                Accommodation a = new Accommodation(grossIncome, exp); //taking variables to next window
                this.Hide();//Hides this window
                a.Show();// Shows accommodation window
            }
            catch (Exception ex)
            {
                //displays error message
                MessageBox.Show(ex.Message+ "Please ensure all fields are entered in correcctly");
            }
            
            

        }

        private double CaptureIncome()
        {
           
               //Extracting value for income from textbox
                double grossIncome = Convert.ToDouble(tbMonthlyIncome.Text);
                return grossIncome;//returning the value

         
        }

             private  Dictionary<string, double> allExpenses()
            {
            //Extracting value for expenses from textboxes
                double tax = Convert.ToDouble(tbTax.Text);
                double groceries = Convert.ToDouble(tbGroceries.Text);
                double rates = Convert.ToDouble(tbRates.Text);
                double travel = Convert.ToDouble(tbTravel.Text);
                double phone = Convert.ToDouble(tbPhone.Text);
                double other = Convert.ToDouble(tbOther.Text);

                //expenses stored as a pair in a generic collection (dictionary)
                Dictionary<string, double> exp = new Dictionary<string, double>();
                exp.Add("Tax", Math.Round(tax, 2));
                exp.Add("Groceries", Math.Round(groceries, 2));
                exp.Add("Rates", Math.Round(rates, 2));
                exp.Add("Travel", Math.Round(travel, 2));
                exp.Add("Phone", Math.Round(phone, 2));
                exp.Add("Other", Math.Round(other, 2));
                //---------------------------------------------------------------

                return exp; //return dictionary
           
            }
        
    }
}
