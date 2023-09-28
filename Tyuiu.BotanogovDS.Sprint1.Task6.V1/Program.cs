using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint1.Task6.V1.Lib;


namespace Tyuiu.BotanogovDS.Sprint1.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Работа со строками класс String                                    *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа.*");
            Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.   *");
            Console.WriteLine("* Рекомендуемый вид экрана во время выполнения программы приведен ниже.    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите символ и нажмите ");

            while (true)
            {
                Console.Write("-> ");
                string input = Console.ReadLine();

                if (input == ".")
                {
                    break;
                }

                string result = dataService.SymbolCode(input);

                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}
