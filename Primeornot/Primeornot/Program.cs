using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, a = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is Composite.");
                    a = 1;
                    break;
                }
            }
            if (a == 0)
                Console.Write("Number is Prime.");
            Console.ReadKey();
        }
    }
}
