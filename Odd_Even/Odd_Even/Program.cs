using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the value of a ");
            a=Convert.ToInt32(Console.ReadLine());
            if(a%2 == 0)
            {
               Console.WriteLine(" a is even");
           
            }
            else
            {
                Console.WriteLine("a is odd");
            }
            Console.ReadKey();
        }
    }
}
