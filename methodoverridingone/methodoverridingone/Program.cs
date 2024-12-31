using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverridingone
{
    class Riding
    {
        public virtual void BaseMethod(int a,int b)
        {
            int c = a * b;
            Console.WriteLine("Multiple of two variable" + c);
        }
    }
    class Derived : Riding
    {
        public virtual void BaseMethod(int x,int y)
        {
            base.BaseMethod(x, y);
            int z = x + y;
            Console.WriteLine("Sum of two variable" + z);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Derived d = new Derived();
            d.BaseMethod(1,2);
            Console.ReadKey();
        }
    }
}
