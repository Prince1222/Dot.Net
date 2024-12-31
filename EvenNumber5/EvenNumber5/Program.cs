using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2, sum = 0;
            do
            {
                i = i + 2;
                sum = sum + i;
            }
            while (i <= 50);
            {
                Console.WriteLine("Sum of even number upto 50 is " + sum);
            }
            Console.ReadKey();
        }

    }
}
