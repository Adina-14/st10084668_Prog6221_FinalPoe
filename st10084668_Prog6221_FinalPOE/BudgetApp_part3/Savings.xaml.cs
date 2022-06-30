using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window

    {
        //Delegate declaration
        public delegate void notifyUserDelegate(double incomeDel, double totalExpenseDel);

        //instant class vehicleLoan
        VehicleLoan vl = new VehicleLoan();

        double grossIncome;
        Dictionary<string, double> exp = new Dictionary<string, double>();

        public Savings(double grossInc, Dictionary<string, double> exps)
        {
            InitializeComponent();
            grossIncome = grossInc;  //assign to global variable
            exp = exps;  //assign to global variable

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Exits program
            Application.Current.Shutdown();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //clears all the text boxes
            tbReason.Text = "";
            tbAmt.Text = "";
            tbIntRate.Text = "";
            tbMonths.Text = "";
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CalSavings();//Method class
            } catch (Exception ex)
            {
                //displays error
                MessageBox.Show(ex.Message + "Please ensure all fields are entered in correcctly");
            }
        }


        public void CalSavings()
        {
            //Extract values from text boxes
            string saveReason = tbReason.Text;
            double saveAmt = Convert.ToDouble(tbAmt.Text);
            double saveIntRate = Convert.ToDouble(tbIntRate.Text);
            int saveMonths = Convert.ToInt32(tbMonths.Text);

            double saveInt = saveIntRate / 100;// convert interest
            int years = saveMonths / 12;// convert month --> years
            double MonthlySavings = (saveAmt * (1 + (saveInt * years))) / saveMonths;// cal monthly savings

            //displays savings
            txtSavings.Text += "\n----------------------------------------------\nSavings: \n----------------------------------------------"
                + "\nSavings Reason : " + saveReason +
                "\nAmount to save : " + saveAmt +
                "\nInterest Rate (%) :" + saveIntRate +
                "\nTime Period (months) :" + saveMonths +
                "\nMonthlySavings : " + MonthlySavings;
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {


            //display Income and  all the Expenses
            var sortedDict = from entry in exp orderby entry.Value descending select entry;//sorting the dictionary into descending order 
            var lines = sortedDict.Select(kv => kv.Key + ": " + kv.Value.ToString());
            txtSavings.Text += "\nIncome : " + grossIncome
                + "\n----------------------------------------------\nExpenses: \n----------------------------------------------\n" + string.Join(Environment.NewLine, lines);


            vl.SetExp(exp);
            //--delegate to notify the user when expenses exceed 75% for their gross income-------
            notifyUserDelegate nud = delegate (double incomeDel, double totalExpenseDel)
            {
                if (totalExpenseDel > (incomeDel * 0.75))
                {

                    txtSavings.Text += "\n----------------------------------------------\nALERT: \n----------------------------------------------\n Your total Expenses exceed 75% of your monthly income";

                }
            };
            nud.Invoke(grossIncome, vl.GetTotalExp());
            //---------------------------------------------------------------------------------------


        }

        //Saving into text file
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "BudgetPlan.txt";
            save.Filter = "Text File | *.txt";
            DateTime dateTime = DateTime.Now;

            if (save.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("BUDGET PLAN : " + dateTime);
                writer.WriteLine(txtSavings.Text);
                writer.Dispose();
                writer.Close();

            }

        }


    }
    
}
