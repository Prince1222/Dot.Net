using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNatural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i=1, sum=0, n;
            Console.WriteLine("Enter the n numbers ");
            n = Convert.ToDouble(Console.ReadLine());
            while (i < n)
            {
                sum = sum + i;
                i++;

            }
            Console.WriteLine(sum + " is sum");
            Console.ReadKey();
            
            
        }
       
    }
}
