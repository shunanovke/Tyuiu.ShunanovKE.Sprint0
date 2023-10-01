using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShunanovKE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт#0 | Выполнил: Шунанов К. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 0                                                                *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Шунанов Кирилл Ерболатович | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения трех    *");
            Console.WriteLine("* элементов и умножает сумму на 5                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 4;
            int y = 6;
            int z = 5;
            Console.WriteLine("Данные числа: " + x + ", " + y + ", " + z);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("(x+y+z)*5 = " + DataService.Calc(x, y, z));
            Console.ReadKey();

        }
    }
}
