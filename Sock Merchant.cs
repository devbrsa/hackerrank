using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32("9");
        string[] c_temp = "10 20 20 10 10 30 50 10 20".Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);

        var distinctValue = c.Distinct().ToArray();
        int total = 0;
        for (int i = 0; i < distinctValue.Length; i++)
        {
            total += c.Count(x => x == distinctValue[i]) / 2;
        }

        Console.WriteLine(total);
    }
}
