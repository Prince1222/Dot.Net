using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            for(a =1;a<=5;a++)
            {
                for(b=1;b<=a;b++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
