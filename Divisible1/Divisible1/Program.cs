using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number to check if number is divisible by 7 but not by 13 or not");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 7 == 0 && a % 13 != 0)
            {
                Console.WriteLine("The number is divisible by 7 but not by 13.");
            }
            else
            {
                Console.WriteLine("The number does not matches the condition.");
            }
            Console.ReadKey();



        }
    }
}
