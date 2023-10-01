using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShunanovKE.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int [] num1, int[] num2)
        {
            int[] resArray = new int[num1.Length];
            for (var i = 0; i < resArray.Length; i++)
            {
                resArray[i] = num1[i] + num2[i];
            }
            return resArray;
        }
    }
}
