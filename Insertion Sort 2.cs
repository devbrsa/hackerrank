using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

class Solution
{
    static void insertionSort(int[] ar)
    {
        for (int i = 1; i < ar.Length; i++)
        {
            var j = i;
            while (ar[j] < ar[j - 1])
            {
                var temp = ar[j - 1];
                ar[j - 1] = ar[j];
                ar[j] = temp;
                if (j > 1) { j--; }
            }
            Debug.WriteLine(string.Join(" ", ar));
        }

        Console.ReadLine();
    }
    /* Tail starts here */
    static void Main(String[] args)
    {

        int _ar_size;
        _ar_size = Convert.ToInt32("6");
        int[] _ar = new int[_ar_size];
        //String elements = Console.ReadLine();
        String[] split_elements = "1 4 3 5 6 2".Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        insertionSort(_ar);

        Console.ReadLine();
    }
}
