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
            string[] tokens_a0 = "5 6 11".Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = "3 6 10".Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            var value = new int[3];

            var a = a0.CompareTo(b0);
            var b = a1.CompareTo(b1);
            var c = a2.CompareTo(b2);

            value[0] = a;
            value[1] = b;
            value[2] = c;

            int alice = 0;
            int bob = 0;

            for (int i = 0; i < 3; i++)
            {
                if (value[i] > 0)
                    alice += 1;
                else if (value[i] < 0)
                    bob += 1;
            }

            Console.WriteLine(alice.ToString() +" " + bob.ToString());
            Console.ReadLine();


        }
    }
}
