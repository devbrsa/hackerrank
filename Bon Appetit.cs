using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
       string[] n_k_temp = Console.ReadLine().Split(' ');
        int[] n_k = Array.ConvertAll(n_k_temp, Int32.Parse);
        int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int charged = Convert.ToInt32(Console.ReadLine());

        int shared = items.Where((x,i)=> i != n_k[1]).Sum();

        if (charged == shared / 2)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(charged - shared / 2);
    }
}