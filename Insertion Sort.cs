using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void insertionSort(int[] ar)
    {
        var last = ar.Last();

        for (int i = ar.Length - 1; i >= 0; i--)
        {
            if (i == 0)
                ar[i] = last;
            else
            {
                if (ar[i - 1] >= last)
                    ar[i] = ar[i - 1];
                else
                {
                    ar[i] = last;
                    Console.WriteLine(string.Join(" ", ar));
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", ar));
        }
    }
    /* Tail starts here */
    static void Main(String[] args)
    {

        int _ar_size;
        _ar_size = Convert.ToInt32("10");
        int[] _ar = new int[_ar_size];
        //String elements = Console.ReadLine();
        String[] split_elements = "2 3 4 5 6 7 8 9 10 1".Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        insertionSort(_ar);

        Console.ReadLine();
    }
}
