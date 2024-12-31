using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, num1 = 0, num2 = 1, nextnum;

            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibonacci series are:");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(num1);

                nextnum = num1 + num2;
                num1 = num2;
                num2 = nextnum;
            }
            Console.ReadKey();

        }
    }
}
