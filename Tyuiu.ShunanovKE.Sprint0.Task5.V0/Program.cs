using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanovKE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(12,45));
            Console.WriteLine("A - B = " + DataService.Subtraction(45,12));
            Console.WriteLine("A * B = " + DataService.Multiplication(10,13));
            Console.WriteLine("A / B = " + DataService.Division(18,2));
            Console.WriteLine("A / B = " + DataService.Division(18,0));
            Console.ReadKey();
        }
    }
}
