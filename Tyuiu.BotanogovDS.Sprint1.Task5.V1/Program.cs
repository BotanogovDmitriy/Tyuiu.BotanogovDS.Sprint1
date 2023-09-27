using System;
using Tyuiu.BotanogovDS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #1 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                          *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                     *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).    *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double x1 = 1;
            double y1 = 1;
            double x2 = 4;
            double y2 = 5;

            DataService dataService = new DataService();
            int distance = dataService.DistanceBetweenDots(x1, y1, x2, y2);

            Console.WriteLine("Введите значение X1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение X2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}): {distance}");

            Console.ReadLine();
        }
    }
}
