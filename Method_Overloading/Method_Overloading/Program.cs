using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Program
    {
        void sum (int a,int b)
        {
            Console.WriteLine(a + b);
        }
        void sum (float a, float b)
        {
            Console.WriteLine(a + b);
        }
        void multi (int a, int b)
        {
            Console.WriteLine(a * b);
        }
        void multi (float a, float b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum(3, 5);
            p.sum(4.5f, 6.4f);
            p.multi(3, 5);
            p.multi(3.4f, 5.6f);
            Console.ReadKey();

        }
    }
}
