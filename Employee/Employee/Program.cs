using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        class Employee
        {
            public int salary = 40000;
        }
        class Programmer : Employee
        {
            public int bonus = 10000;
            public void Display()
            {
                Console.WriteLine("The salary amount is " + salary);
                Console.WriteLine("The bonus amount is " + bonus);
            }
        }
        
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.Display();
            Console.ReadKey();
        }
    }
}
