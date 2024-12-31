using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter the numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b) 
            { 
                Console.WriteLine("The first variable is biggest one");
            }
            else
            {
                Console.WriteLine("The second variable is biggest number");
                
            }
            Console.ReadKey();
        }
    }
}
