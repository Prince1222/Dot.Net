
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace Biggest3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int a, b, c;
                Console.WriteLine("Enter the numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                {
                    if (a <c)
                    {
                        Console.WriteLine("a is the smallest one");

                    }
                    else
                    {
                        Console.WriteLine("c is the smallest one");
                    }
                }
                else
                {
                    if (b < c)
                    {
                        Console.WriteLine("b is the smallest one");
                    }
                    else
                    {
                        Console.WriteLine("c is the smallest one");
                    }
                    
                }
            Console.ReadKey();
        }
        }
    }


