using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
       string[] s1 = Console.ReadLine().Split(' ');
        int size = int.Parse(s1[0]);
        int rotation = int.Parse(s1[1]);

        string[] s = Console.ReadLine().Split(' ');
        int[] array = new int[size];

        ////pre-rotation of array method:
        //-----------------------------------Right rotation
        //for (int i = 0; i < n; i++)
        //{
        //    array[(i + rotation) % size] = int.Parse(s[i]);
        //}

        //------------------------------------Left rotation
        for (int i = 0; i < size; i++)
        {
            array[(i + (size - rotation)) % size] = int.Parse(s[i]);
        }

        string value = null;

        for (int i = 0; i < size; i++)
        {
            value += array[i] + " ";
        }

        Console.WriteLine(value);
        Console.ReadKey();
    }
}