using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstrauctor
{
    internal class Cons
    { 
        public Cons()
        {
            Console.WriteLine("I am inside the normal constructor");
        }
        static Cons()
        {
            Console.WriteLine("I am inside the static constructor");
        }
        static void Main(string[] args)
        {
            new Cons();
            new Cons();
            Console.ReadKey();
        }
    }
}
