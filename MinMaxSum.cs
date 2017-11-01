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

            long[] intValues = new long[5];

            if (!args.Any())
                intValues = Array.ConvertAll(new string[5] { "1", "2", "3", "4", "5" }, s => long.Parse(s));
            else
                intValues = Array.ConvertAll(args, s => long.Parse(s));

            var listTotal = new long[intValues.Length];

            for (int i = 0; i < intValues.Length; i++)
            {
                long total = 0;
                for (int j = 0; j < intValues.Length; j++)
                {

                    if (i != j)
                        total += intValues[j];
                }
                listTotal[i] = total;
            }
            Console.WriteLine(listTotal.Min() + " " + listTotal.Max());


            Console.ReadKey();
        }
    }
}