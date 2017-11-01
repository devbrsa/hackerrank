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
        int n = Convert.ToInt32(Console.ReadLine());

        BigInteger value = n;

        for (int i = 1; i < n; i++)
        {
            value = value * i;
        }

        Debug.WriteLine(value.ToString());
    }
}
