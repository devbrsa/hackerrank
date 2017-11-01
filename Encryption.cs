using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution
{

    static void Main(String[] args)
    {
        //Func<int, int, IEnumerable<int>> f = (a, b) => Enumerable.Range(0, a / b).Select((n) => a / b + ((a % b) <= n ? 0 : 1));
        //var x = "test".Substring(0, 5);
        var phrase = "if man was meant to stay on the ground god would have given us roots";
        int num = 1;
        int max = 0;
        for (int i = 1; i < phrase.Length; i++)
        {
            num = (phrase.Length % i);
            if (num > max)
                max = num;
        }
        while (num < 10)
        {

            var array = Split(phrase.Replace(" ", string.Empty), num);

            var rows = array.Count();
            var columns = array.First().Count();
            var total = rows * columns;
            if (num!=1 && total <= phrase.Length)
                break;
            else
            {
                num++;
            }


        }
    }

    static IEnumerable<string> Split(string str, int chunkSize)
    {
        int divisor = (int)Math.Round(Convert.ToDecimal(str.Length) / Convert.ToDecimal(chunkSize));

        return Enumerable.Range(0, divisor)
            .Select(i => str.Length - (i * chunkSize) < chunkSize ? str.Substring(str.Length - i) : str.Substring(i * chunkSize, chunkSize));


    }
}
