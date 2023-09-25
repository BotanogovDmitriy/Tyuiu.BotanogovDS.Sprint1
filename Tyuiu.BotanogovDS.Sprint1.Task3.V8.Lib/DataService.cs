using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BotanogovDS.Sprint1.Task3.V8.Lib
{       

    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double percent, double timeDays)
        {
            double depositAmount = 2500;
            double dailyInterestRate = percent / (365 * 100); 
            double income = depositAmount * dailyInterestRate * timeDays;

            return income;
        }
    }
}
