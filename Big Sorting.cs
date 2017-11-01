using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];

        for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
        {
            unsorted[unsorted_i] = Console.ReadLine();
        }

        Array.Sort(unsorted, new Compare());

        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.WriteLine(unsorted[i]);
        }


        // your code goes here
    }
}

class Compare : IComparer<string>
{
    int IComparer<string>.Compare(string x, string y)
    {
        if (x.Length > y.Length)
            return 1;
        else if (x.Length < y.Length)
            return -1;
        else if (x.Length == y.Length)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > y[i])
                    return 1;
                if (x[i] < y[i])
                    return -1;
            }
        }
        return 0;
    }
}
