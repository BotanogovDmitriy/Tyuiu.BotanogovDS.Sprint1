using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #8                                                               *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                 *");
            Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются во время  *");
            Console.WriteLine("* работы программы.                                                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Величина вклада (руб.) -> 2500                                           *");
            Console.WriteLine("* Срок вклада (дней) -> 30                                                 *");
            Console.WriteLine("* Процентная ставка (годовых) -> 20                                        *");
            Console.WriteLine("* Доход: 41.10 руб.                                                        *");
            Console.WriteLine("* Сумма по окончании срока вклада: 2541.10 руб.                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите величину вклада (руб.): ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок вклада (дней): ");
            int depositDuration = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите процентную ставку (годовых): ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double income = ds.IncomeAmount(interestRate, depositDuration);
            double totalAmount = depositAmount + income;

            Console.WriteLine("Доход: " + income.ToString("F2") + " руб.");
            Console.WriteLine("Сумма по окончании срока вклада: " + totalAmount.ToString("F2") + " руб.");

            Console.ReadLine();
        }
    }
}
