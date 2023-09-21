using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BotanogovDS.Sprint1.Task1.V29.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                DataService ds = new DataService();

                Console.Title = "Спринт №1 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Организация ввода / вывода в консольных приложениях               *");
                Console.WriteLine("* Задание #1                                                              *");
                Console.WriteLine("* Вариант #29                                                             *");
                Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                      *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
                Console.WriteLine("* вычисляет результат по формуле a*b*c/(a+b+c)                            *");
                Console.WriteLine("* и печатает его на экране.                                               *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                double a, b, c;

                Console.WriteLine("Введите значение A:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение B:");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение C:");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.Calculate(a, b, c));

                Console.ReadLine(); 
            }
        }
    }
}
