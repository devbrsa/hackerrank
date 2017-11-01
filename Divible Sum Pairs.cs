using System;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = "6 3".Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = "1 3 2 6 1 2".Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            var array = a.Skip(i).ToArray();

            for (int j = 0; j < array.Length; j++)
            {
                if (j + 1 == array.Length)
                    break;
                if ((array.First() + array[j + 1]) % k == 0)
                    count++;
            }
        }

        Console.WriteLine(count);
        Console.ReadLine();
    }
}
