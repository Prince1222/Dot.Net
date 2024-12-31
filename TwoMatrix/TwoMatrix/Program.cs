using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, m, n, p, q;

            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];

            Console.WriteLine("Enter the size of first matrix:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of second matrix:");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());

            if (m == p && n == q)
            {
                Console.WriteLine("Enter the elements in to first matrix:");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter the elements in to second matrix:");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                    }
                }

                Console.WriteLine("The result matrix is=");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        Console.Write("\t" + c[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Case does not match");
            }

            Console.ReadLine();

        }
    }
}
