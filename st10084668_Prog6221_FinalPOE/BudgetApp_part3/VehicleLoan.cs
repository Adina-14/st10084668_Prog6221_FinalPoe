using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_part3
{
    public class VehicleLoan : Expenses 
    {
        private string model; //model of vehicle
        private string make; //make of vehicle
        private double purPrice; //purchase price of vehicle
        private double totDep; //total deposit for vehicle
        private double intRate; //interest rate
        private double insurance; //Estimate insurance premium

        //encapsulate fields
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public double PurPrice { get => purPrice; set => purPrice = value; }
        public double TotDep { get => totDep; set => totDep = value; }
        public double IntRate { get => intRate; set => intRate = value; }
        public double Insurance { get => insurance; set => insurance = value; }

        double monthlyPayment = 0;
        public double CalRepayment()
        {
            

            //--------------------------calculation for vehicle payments----------------------------
            double principleAmt = purPrice - totDep; //calc amount to be paid
            intRate = intRate / 100; //converts rate into correct format
            double vehicleCost = principleAmt * (1 + (intRate * 5)); // formula: A=P(1+(ixn)
            monthlyPayment = (vehicleCost / 60) + insurance; //monthly payments including insurance
            //--------------------------------------------------------------------------------------
            
            return monthlyPayment;
        }

        //override abstarct method
        override public double avaliableMoney(double grossIncome)
        {
            

            //-----------calculating available money at the end of the month-------
            double avaMoney = grossIncome - (monthlyPayment + GetTotalExp());
            //---------------------------------------------------------------------

            //--------Store in dictionary-----
            exp.Add("Vehicle", Math.Round(monthlyPayment, 2));
            //--------------------------------

            return avaMoney; //return avaliable money
        }
    }
}
