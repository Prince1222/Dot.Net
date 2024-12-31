using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2, sum = 0;
            do
            {
                sum = sum + i;
                i = i + 2;
                
            }
            while (i <= 100);
            {
                Console.WriteLine("Sum of Even Numbers up to 100 is " + sum);
            }
            Console.ReadKey();
        }
    }
}
