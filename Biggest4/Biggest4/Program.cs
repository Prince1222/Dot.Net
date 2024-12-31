using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter value of a,b,c,d:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine(a + "is biggest");
                    }
                    else
                    {
                        Console.WriteLine(d + "is biggest");
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine(c + "is biggest");
                    }
                    else
                    {
                        Console.WriteLine(d + "is biggest");
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine(b + "is biggest");
                    }
                    else
                    {
                        Console.WriteLine(d + "is biggest");
                    }
                }
            }
            Console.ReadKey();

        }
    }
}