using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint0.Task7.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт#0 | Выполнил: Шунанов К. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 0                                                                *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Шунанов Кирилл Ерболатович | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] ArrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения массива 1:");
            for (var i = 0; i < ArrayNums1.Length; i++)
            {
                Console.Write(ArrayNums1[i] + ", ");
            }
            Console.WriteLine();
            int[] ArrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значения массива 2:");
            for (var i = 0; i < ArrayNums2.Length; i++)
            {
                Console.Write(ArrayNums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ArrayNums1.Length == ArrayNums2.Length)
            {
                int[] resArray = DataService.AdditionArrays(ArrayNums2, ArrayNums1);
                Console.WriteLine("Сумма элементов массива равна:");
                for (int i = 0; i < resArray.Length; i++)
                {
                    Console.Write(resArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Длины массивов не совпадают");
            }
            Console.ReadKey();
        }
    }
}
