using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Useinterface2
{

        abstract class A
        {
            public void MessageA() {
                Console.WriteLine("This is from abstract class");
          
            }

        }
        class B : A
        {
            public void MessageB()
            {
                Console.WriteLine("This is another message");
            
            }
        }
  class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.MessageA();
            obj.MessageB();
            Console.ReadLine();
        }
        
        
    }
   
}

