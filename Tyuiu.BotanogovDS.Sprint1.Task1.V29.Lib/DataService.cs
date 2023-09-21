using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces;

namespace Tyuiu.BotanogovDS.Sprint1.Task1.V29.Lib
{

    public class DataService : ISprint1Task1V29
    {
        public double Calculate(double a, double b, double c)
        {
            return a * b * c / (a + b + c); 
        }
    }
}
