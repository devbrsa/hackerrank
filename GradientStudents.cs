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
            int[] gradesRaw = new int[n];

            for (int i = 0; i < n; i++)
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(grade < 38 ? grade : 5 - grade % 5 < 3 ? 5 - grade % 5 + grade : grade);
            }
            //    {
            //        gradesRaw[i] = grade;
            //        continue;
            //    }

            //    var getRound = 5 - grade % 5;
            //    if (getRound < 3)
            //        gradesRaw[i] = grade + getRound;
            //    else
            //    {
            //        gradesRaw[i] = grade;
            //    }
            //}

            //for (int i = 0; i < gradesRaw.Length; i++)
            //{
            //    Console.WriteLine(gradesRaw[i]);
            //}
            //Console.ReadLine();
        }
    }
}