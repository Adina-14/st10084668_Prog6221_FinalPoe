using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_part3
{
    public class Rent : Expenses
    {
        private double rentAmt;

        public double RentAmt { get => rentAmt; set => rentAmt = value; } //encapsulate variable

        //override abstarct method 
        override public double avaliableMoney(double grossIncome)
        {
           
            
            double avaMoney = grossIncome - (rentAmt + GetTotalExp());//cal avaliable money

           //Add to dictionary
            exp.Add("Rent", Math.Round(rentAmt, 2));

            return avaMoney; //return avaMoney
        }
    }
    
}
