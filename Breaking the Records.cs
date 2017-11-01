using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int[] getRecord(int[] s)
    {
        int max = 0;
        int min = 0;
        int countMax = 0;
        int countMin = 0;


        for (int i = 0; i < s.Length; i++)
        {
            if (i == 0)
            {
                max = min = s[i];
            }

            if (s[i] > max)
            {
                max = s[i];
                countMax++;
            }

            if (s[i] < min)
            {
                min = s[i];
                countMin++;
            }
        }
        return new int[2] { countMax, countMin };
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
