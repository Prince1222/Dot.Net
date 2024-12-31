using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiinheritance
{
    class A

    {
        public int a, b, c;
        public void ReadData(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Display()
        {
            Console.WriteLine("The value of a is=" + a);
            Console.WriteLine("The value of b is=" + b);
        }
    }
    class B : A
    {
        public void add()
        {
            base.c = base.a + base.b;
            Console.WriteLine("The sum is=" + base.c);
        }
    }
    class C : B
    {
        public void Sub()
        {
            base.c = base.a - base.b;
            Console.WriteLine("The difference is=" + base.c);
        }
    }
    class Mlevel
    {

   
    internal class Program
    {
        static void Main(string[] args)
        {
                C obj = new C();
                obj.ReadData(30, 20);
                obj.Display();
                obj.Sub();
                Console.ReadKey();
            }
        }
}
}
