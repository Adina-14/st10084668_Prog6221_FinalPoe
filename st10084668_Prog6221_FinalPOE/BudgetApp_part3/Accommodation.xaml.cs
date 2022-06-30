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
    /// Interaction logic for Accommodation.xaml
    /// </summary>
    public partial class Accommodation : Window
    {
        Rent r = new Rent();//instant class
        HomeLoan hl= new HomeLoan();//instant class

        //global declare
        double grossIncome;
        Dictionary<string, double> exp = new Dictionary<string, double>();

        public Accommodation(double grossInc , Dictionary<string, double> exps)
        {
            InitializeComponent();

            grossIncome = grossInc; //assign to global variable
            exp =  exps;//assign to global variable

        }
        
        



        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Exits application
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((rbRenting.IsChecked == true) || (rbBuying.IsChecked == true))// check if either radiobutton was checked
            {
               

                try
                {
                    if (rbRenting.IsChecked == true)
                    {
                        Renting(); //call method
                    }

                    if (rbBuying.IsChecked == true)
                    {
                        Buying();//call Method
                    }


                    Vehicle v = new Vehicle(grossIncome, exp); //taking variables to next window
                    this.Hide();//hides this window
                    v.Show();//shows Vehicle window
                }
                catch (Exception ex)
                {
                    //Displays error message
                    MessageBox.Show(ex.Message + "\nPlease ensure all fields are entered coreectly");
                }
            }
            else
            {
                //Displays error message
                MessageBox.Show("Please choose Renting or Buying a Property");
            }
        }

        public void Buying()
        {
            //assign values to Home loan class variables
            hl.PropertyPrice = Convert.ToDouble(tbPPrice.Text);
            hl.TotalDeposit = Convert.ToDouble(tbDeposit.Text);
            hl.InterestRate = Convert.ToDouble(tbDeposit.Text);

             
                    //values depends on which radio button was checked
                    if (rbtime1.IsChecked == true)
                    {
                        hl.Months = 240;//assign the number of months
                    }
                    if (rbtime2.IsChecked == true)
                    {
                        hl.Months = 360;//assign the number of months

                    }

           
            //Call methods from Home loan class
            try
            {
                hl.SetExp(exp);
                double repay = hl.CalRepayment();
                double avaMoney = hl.avaliableMoney(grossIncome);
                //display monthly repayments and current avaliable money
                MessageBox.Show("Monthly Repayments: R" + Math.Round(repay, 2) + "\nAvaliable Money: R" + Math.Round(avaMoney, 2));
            }catch (Exception exs)
            {
                MessageBox.Show(exs.Message + "\nPlease ensure all fields are entered coreectly");
            }
        }

        public void Renting()
        {
            //Call methods from Rent class
            r.RentAmt = Convert.ToDouble(tbRentAmt.Text);
            r.SetExp(exp);
            double avaMoney = r.avaliableMoney(grossIncome);
            //Displays current avaliable money
            MessageBox.Show("Avaliable Money: R" + Math.Round(avaMoney,2));
        }

        private void rbRenting_Checked(object sender, RoutedEventArgs e)
        {
           
                //make rent label and textbox visible
                tbRentAmt.Visibility = Visibility.Visible;
                lblRent.Visibility = Visibility.Visible;
                
                //make buying labels and textboxes invisible
                lblPropPrice.Visibility = Visibility.Hidden;
                tbPPrice.Visibility = Visibility.Hidden;
                lblDeposit.Visibility = Visibility.Hidden;  
                tbDeposit.Visibility = Visibility.Hidden;
                lblInterest.Visibility = Visibility.Hidden;
                tbInterest.Visibility = Visibility.Hidden;
                lblTime.Visibility = Visibility.Hidden;
                rbtime1.Visibility = Visibility.Hidden;
                rbtime2.Visibility = Visibility.Hidden;

            
           
        }

        private void rbBuying_Checked(object sender, RoutedEventArgs e)
        {
            //make buying labels and textboxes visible
            lblPropPrice.Visibility = Visibility.Visible;
            tbPPrice.Visibility = Visibility.Visible;
            lblDeposit.Visibility = Visibility.Visible;
            tbDeposit.Visibility = Visibility.Visible;
            lblInterest.Visibility = Visibility.Visible;
            tbInterest.Visibility = Visibility.Visible;
            lblTime.Visibility = Visibility.Visible;
            rbtime1.Visibility = Visibility.Visible;
            rbtime2.Visibility = Visibility.Visible;

            //make rent label and textbox invisible
            tbRentAmt.Visibility = Visibility.Hidden;
            lblRent.Visibility = Visibility.Hidden;
        }
    }
}
