using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint1.Task0.V26.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                          *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #26                                                              *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (4 * 5) / 2 - 18 / 2 / 3 *");
            Console.WriteLine("* и печатает результат на экране.                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* (4 * 5) / 2 - 18 / 2 / 3                                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
