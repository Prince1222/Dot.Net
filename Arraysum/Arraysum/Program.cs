using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int n, i, sum = 0;
            Console.WriteLine("Enter the size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in to an array:");
            for (i = 0; i < n; i++) { 
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++) { 
                sum = sum + a[i];
            Console.WriteLine("The sum of all array elements are:" + sum);
            }
            Console.ReadKey();
        }
    }
