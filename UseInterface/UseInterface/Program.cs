using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseInterface
{
    abstract class A
    {
        public abstract int AddData(int a, int b);
    }
    class B : A
    {
        public override int AddData(int a, int b)
        {
            return a + b;
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
           int res = b.AddData(1, 2);
            Console.WriteLine("Sum is ="+res);
            Console.ReadLine();
        }
    }
}
