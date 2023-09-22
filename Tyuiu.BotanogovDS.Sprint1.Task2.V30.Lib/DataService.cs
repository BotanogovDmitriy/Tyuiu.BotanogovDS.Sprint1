using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BotanogovDS.Sprint1.Task2.V30.Lib
{
    public class DataService : ISprint1Task2V30
    {
        public double ConvertKmToMetre(double value)
        {
            return value * 1000;
        }
    }
}
