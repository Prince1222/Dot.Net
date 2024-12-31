using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("a is the smallest");

            }
            else { Console.WriteLine("b is the smallest"); }
            Console.ReadKey()
        }
    }
}
