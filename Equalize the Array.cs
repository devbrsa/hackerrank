using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
         int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(c_temp, Int32.Parse);

                Console.WriteLine(array.Length - Convert.ToInt32(array.GroupBy(x => x).Select(y => new { y.Key, Count = y.Count() }).Max(z => z.Count)));
    }
}