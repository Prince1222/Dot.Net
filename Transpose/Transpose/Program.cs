using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n, temp;
            int[,] a = new int[10, 10];
            Console.WriteLine("Enter the size of matrix:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            if (m == n)
            {
                Console.WriteLine("Enter the elements in to matrix:");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)

                    {

                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < i; j++)

                    {

                        temp = a[i, j];
                        a[i, j] = a[j, i];
                        a[j, i] = temp;
                    }
                }
                Console.WriteLine("The matrix after transpose is=");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("\t" + a[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Matrix transpose is not possible");
            }
            Console.ReadKey();
        }
    }
}
  