using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int n, i, r;
            Console.WriteLine("Enter your choice:");
            n=Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <=10;i++)
            {
               
                r = n * i;
                Console.WriteLine("Result: " +r);
               

            }
            Console.ReadLine();
        }
    }
}
