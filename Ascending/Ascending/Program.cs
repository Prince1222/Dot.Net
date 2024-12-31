using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, temp;
            int[] a = new int[100];
            Console.Write("Enter the size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in an array:");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for
            (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])

                    {

                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                }
            }

            Console.WriteLine("The array elemént after sorting in ascending order is:");
        for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);

            }
            Console.ReadKey();
        }
    }
}