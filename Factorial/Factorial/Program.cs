using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, fac=1;
            Console.WriteLine("Enter the number for factorial:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fac = fac * i;
                
            }
            Console.WriteLine($"Factorial number of {num} is {fac}");
            Console.ReadKey();

        }
    }
}
