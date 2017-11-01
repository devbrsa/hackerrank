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
            string[] h_temp = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5".Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();

            char[] alphabetic = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            char[] splitWord = word.ToCharArray();

            int max = 0;
            int position = 0;
            for (int i = 0; i < splitWord.Length; i++)
            {
                position = Array.IndexOf(alphabetic, splitWord[i]);

                if (h[position] > max)
                    max = h[position];
            }
            Console.WriteLine(max*word.Count());
            Console.ReadLine();
        }
    }
}