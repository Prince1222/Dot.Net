using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the numbers:");
            b= Convert.ToDouble(Console.ReadLine());
            for(a = 1; a < 11; a++)
            {
                c = b * a;
                Console.WriteLine("Multiplication is " + c);
            }
            Console.ReadKey();
        }
    }
}
