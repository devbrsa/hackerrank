using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string s = "saveChangesInTheEditor";

        Console.WriteLine(s.Where(x => Char.IsUpper(x)).Count()+1);
    }
}
