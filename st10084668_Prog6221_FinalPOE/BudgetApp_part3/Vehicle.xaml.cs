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
    /// Interaction logic for Vehicle.xaml
    /// </summary>
    public partial class Vehicle : Window
    {
        VehicleLoan vl = new VehicleLoan();//instant class

        //global variable
        double grossIncome;
        Dictionary<string, double> exp = new Dictionary<string, double>();

        public Vehicle(double grossInc, Dictionary<string, double> exps)
        {
            InitializeComponent();
            grossIncome = grossInc;  //assign to global variable
            exp = exps;  //assign to global variable

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Exits Application
            Application.Current.Shutdown();
        }

        private void rbBuying_Checked(object sender, RoutedEventArgs e)
        {
            //Makes all components visible for buying a car
            lblMake.Visibility = Visibility.Visible;
            tbMakeModel.Visibility = Visibility.Visible;
            lblpPrice.Visibility = Visibility.Visible;
            tbPurPrice.Visibility = Visibility.Visible;
            lblDeposit.Visibility = Visibility.Visible;
            tbDeposit.Visibility = Visibility.Visible;
            lblInterest.Visibility = Visibility.Visible;
            tbInterest.Visibility = Visibility.Visible;
            lblInsurance.Visibility = Visibility.Visible;
            tbInsurance.Visibility = Visibility.Visible;
        }

        private void rbNotBuying_Checked(object sender, RoutedEventArgs e)
        {
            //Makes all components invisible when not buying a car
            lblMake.Visibility = Visibility.Hidden;
            tbMakeModel.Visibility = Visibility.Hidden;
            lblpPrice.Visibility = Visibility.Hidden;
            tbPurPrice.Visibility = Visibility.Hidden;
            lblDeposit.Visibility = Visibility.Hidden;
            tbDeposit.Visibility = Visibility.Hidden;
            lblInterest.Visibility = Visibility.Hidden;
            tbInterest.Visibility = Visibility.Hidden;
            lblInsurance.Visibility = Visibility.Hidden;
            tbInsurance.Visibility = Visibility.Hidden;
        }

        public void BuyingVehicle()
        {
            //Extract and assign variables from textBoxes
            vl.Make = tbMakeModel.Text;
            vl.PurPrice = Convert.ToDouble(tbPurPrice.Text);
            vl.TotDep = Convert.ToDouble(tbDeposit.Text);
            vl.IntRate = Convert.ToDouble(tbInterest.Text);
            vl.Insurance = Convert.ToDouble(tbInsurance.Text);


            //call methods from vehicle loan
            vl.SetExp(exp);
            double repay = vl.CalRepayment();

           double avaMoney = vl.avaliableMoney(grossIncome);
            //Display Monthly repayment and current avaliable money
            MessageBox.Show("Monthly Repayments: R" + Math.Round(repay,2) + "\nAvaliable Money: R" + Math.Round(avaMoney,2));

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //checks if either radio button is check
            if ((rbBuying.IsChecked == true) || (rbNotBuying.IsChecked == true))
            {
                try
                {
                    if (rbBuying.IsChecked == true)
                    {
                        BuyingVehicle();//method call
                    }

                    if (rbNotBuying.IsChecked == true)
                    {
                        MessageBox.Show("You've chose not to buy a vehicle.\nPlease continue>");//display message
                    }

                    Savings s = new Savings(grossIncome, exp);//takes variables over to savings window
                    this.Hide();//hides this window
                    s.Show();//shows savings window
                }
                catch (Exception ex)
                {
                    //Displays error message
                    MessageBox.Show(ex.Message + "\nPlease ensure all fields are entered correctly");
                }
            }
            else
            {
                //Displays error message
                MessageBox.Show("Please choose Buying or Not buying a Vehicle");
            }
}

       
    }
}
