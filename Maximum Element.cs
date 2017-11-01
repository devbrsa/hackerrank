using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        var sizeOfN = Convert.ToInt32(Console.ReadLine());

        Stack<long> list = new Stack<long>(capacity: sizeOfN);

        while (sizeOfN > 0)
        {
            var command = Console.ReadLine();

            switch (Convert.ToInt64(command.Split(' ')[0]))
            {
                case 1:
                    list.Push(Convert.ToInt64(command.Split(' ')[1]));
                    break;
                case 2:
                    list.Pop();
                    break;
                case 3:
                    var array = list.ToArray();
                    long? maxVal = null; //nullable so this works even if you have all super-low negatives
                    long index = -1;
                    for (long j = 0; j < array.Length; j++)
                    {
                        long thisNum = array[j];
                        if (!maxVal.HasValue || thisNum > maxVal.Value)
                        {
                            maxVal = thisNum;
                            index = j;
                        }
                    }
                    Console.WriteLine(maxVal);
                    break;
            }

            sizeOfN--;
        }

        Console.Read();
    }
}