using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32("5");
            string[] arr_temp = "1000000001 1000000002 1000000003 1000000004 1000000005".Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            long value = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                value += arr[i];
            }

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
