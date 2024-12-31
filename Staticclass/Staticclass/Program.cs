using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticclass
{
    internal class Program
    {
        static class Person
        {
            public static int id;
            public static string name;
            public static void Display()
            {
                Console.WriteLine("Your Id = {0}\t and Name = {1}", id, name);
            }
        }
        class TestProgram
        {
            static void Main(string[] args)
            {
                Person.id = 001;
                Person.name = "Anik";
                Person.Display();
                Console.ReadKey();
            }
         
        }
    }
}