using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_part3
{
    public class HomeLoan : Expenses
    {
        //declare variables
        private double propertyPrice;
        private double totalDeposit;
        private double interestRate;
        private int months;

        //encapsulate variables
        public double PropertyPrice { get => propertyPrice; set => propertyPrice = value; }
        public double TotalDeposit { get => totalDeposit; set => totalDeposit = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int Months { get => months; set => months = value; }

        //variable created outside methods
        double monthlyRepay = 0;
        public double CalRepayment()
        {
            //calculation
            double PrincipleAmt = propertyPrice - totalDeposit;
            double interest = interestRate / 100; //decimal
            int years = months / 12; //in years

            //monthly repayment
            monthlyRepay = (PrincipleAmt * (1 + (interest * years))) / months;

           
            return monthlyRepay;//return monthly repayment

        }

        //override abstarct method
        override public double avaliableMoney(double grossIncome)
        {
            //cal avaliable money
            double avaMoney = grossIncome - (monthlyRepay + GetTotalExp());
            //Add to dictionary
            exp.Add("Home Loan Repayment", Math.Round(monthlyRepay, 2));
            return avaMoney;//return avaliable money
        }
    }
}
