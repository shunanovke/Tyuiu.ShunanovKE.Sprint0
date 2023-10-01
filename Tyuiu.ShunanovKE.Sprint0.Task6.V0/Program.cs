using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(nums));
            Console.WriteLine("Разность элементов массива = " + DataService.AdditionSubtraction(nums));
            Console.WriteLine("Произведение элементов массива = " + DataService.AdditionMultiply(nums));
            Console.ReadKey();
        }
    }
}
