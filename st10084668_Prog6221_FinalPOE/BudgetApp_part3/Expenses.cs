using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp_part3
{
    public abstract class Expenses
    {
        //variables
        protected Dictionary<string, double> exp = new Dictionary<string, double>();
        protected double totalExp = 0;


        public void SetExp(Dictionary<string, double> e)
        {

            exp = e;
        }

        public double GetTotalExp()
        {
            //calc the sum of all expenses
            foreach (double value in exp.Values)
            {
                totalExp += value;
            }
            //return sum
            return totalExp;
        }

        //abstract method
        public abstract double avaliableMoney(double grossIncome);

    }
}
