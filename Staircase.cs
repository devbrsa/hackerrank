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
            int n = Convert.ToInt32(Console.ReadLine());
            var staircase = new char[n][];

            for (int i = 0; i < n; i++)
            {
                //staircase[i][n-1] = new String('#', (i+1));
                staircase[i] = new String('#', (i + 1)).PadLeft(n).ToCharArray();
                Console.WriteLine(staircase[i]);
                
            }
            Console.ReadKey();
        }
    }
}