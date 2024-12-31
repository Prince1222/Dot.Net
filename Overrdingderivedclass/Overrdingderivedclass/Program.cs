using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overrdingderivedclass
{
    class Base
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("I am inside base class");
        }
    }
    class Derived : Base
    {
        public override void BaseMethod() {
           //base.BaseMethod();
            Console.WriteLine("I am inside derived class ");
        }
    }
    internal class Program
    {
        class BaseEx { 
        static void Main(string[] args)
        {
                Derived d = new Derived();

              //d.BaseMethod();
                Console.ReadKey();
        }
    }
}
}