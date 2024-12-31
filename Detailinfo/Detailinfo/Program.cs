using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detailinfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Input Value of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n The first {0} natural numbers are:\n", n);

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nThe Sum of Natural Numbers up to {0} terms : {1} \n", n, sum);
            Console.ReadKey();





        }
    }
}
