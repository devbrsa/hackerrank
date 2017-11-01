using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);

            int count = 0;

            for (int i = a.Last(); i <= b.First(); i++)
            {
                if (hasFactors(i, a) && isFactor(i, b))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

        public static Boolean hasFactors(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (num % arr[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static Boolean isFactor(int num, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % num != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}