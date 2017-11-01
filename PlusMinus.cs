using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = 6;
            string[] arr_temp = "-4 3 -9 0 4 1".Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int positiveCount = arr.Count(x => x > 0);
            int negativeCount = arr.Count(x => x < 0);
            int zeroCount = arr.Count(x => x == 0);

            Console.WriteLine(Math.Round(positiveCount / Convert.ToDecimal(n), 6).ToString("N6"));
            Console.WriteLine(Math.Round((decimal)(negativeCount / Convert.ToDecimal(n)), 6).ToString("N6"));
            Console.WriteLine(Math.Round((decimal)(zeroCount / Convert.ToDecimal(n)), 6).ToString("N6"));

            

            Console.ReadKey();
        }
    }
}