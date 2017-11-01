using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int solve(int n, int[] s, int d, int m)
    {
        int value = 0;

        for (int i = 0; i < n; i++)
        {
            if (s.Skip(i).Take(m).Sum() == d)
                value++;
        }

        return value;
    }

    static void Main(String[] args)
    {
        int n = 5;
        string[] s_temp = "1 2 1 3 2".Split(' ');
        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
        string[] tokens_d = "3 2".Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}


//19
//2 5 1 3 4 4 3 5 1 1 2 1 4 1 3 3 4 2 1
//18 7