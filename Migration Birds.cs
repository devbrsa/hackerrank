using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = 6;
        string[] types_temp = "1 4 4 4 5 3 3 3".Split(' ');
        int[] types = Array.ConvertAll(types_temp, Int32.Parse);
        // your code goes here

        var distinct = types.Distinct();
        var dict = new Dictionary<int, int>();

        foreach (var type in distinct)
        {
            dict.Add(type, types.Count(x => x == type));
        }

        var max = dict.Values.Max();
        var maxDict = dict.Where(x=>x.Value==max).Select(y=>y.Key).ToArray();

        Console.WriteLine(maxDict.Min());

        Console.ReadLine();
    }
}
