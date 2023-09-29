using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShunanivKE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ShunanivKE.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 2));
            Console.WriteLine(DataService.Subtraction(7,3));
            Console.WriteLine(DataService.Multiplication(3, 4));
            Console.WriteLine(DataService.Division(48, 8));
            Console.ReadKey();
        }
    }
}
