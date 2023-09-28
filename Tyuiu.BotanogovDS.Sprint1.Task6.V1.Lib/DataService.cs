using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BotanogovDS.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            if (value.Length != 1)
            {
                char symbol = value[0];
                int code = char.ConvertToUtf32(symbol.ToString(), 0);

                return $"Символ: {symbol}\nКод: {code}";
            }

            
        }
    }
}
