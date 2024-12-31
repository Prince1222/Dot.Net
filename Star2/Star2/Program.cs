using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star2
{
     public class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            for( a = 5; a >= 1; a--)
            {
                for(b =1; b <= a; b++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
