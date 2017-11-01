using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(3);
            int[][] a = new int[][]
            {
                new int[] {11,2,4},
                new int[] {4,5,6},
                new int[] {10,8,-12}
            };

            int d = CalcMatrixDiag(a,n);

            var b = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i].Reverse().ToArray();
            }

            int e = CalcMatrixDiag(b,n);
            
            Console.WriteLine(Math.Abs(d-e));
            Console.ReadLine();
        }

        static int CalcMatrixDiag(int[][] matrix, int dimension)
        {
            int value = 0;
            for (int i = 0; i <= dimension-1; i++)
            {

                for (int j = 0; j <= dimension-1; j++)
                {
                    if (i == j)
                    {
                        value = value + matrix[i][j];
                    }
                }
            }
            return value;
        }
		
		    var d1_v = 0;
            var d2_v = 0;

            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
                d1_v += a[a_i][a_i];
                d2_v += a[a_i][(n - 1) - a_i];

            }

            Console.WriteLine(Math.Abs(d1_v - d2_v));
            Console.ReadLine();
    }
}