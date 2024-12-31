using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            try { 
            int result = n1 / n2;
            Console.WriteLine("The result is=" + result);
            }
            catch(DivideByZeroException ex) {

                Console.WriteLine("The number cannot be divided by zero");
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
        
    }
}
