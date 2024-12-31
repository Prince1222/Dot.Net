using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
  sealed  class A
    {
        public void display()
        {
            Console.WriteLine("this is a message");
        }
        
        
    }
    class A : B { 
     Console.WriteLine("this is a another message");
    }
    internal class Program
    {bh
        static void Main(string[] args)
        {
            A a = new A();  
            a.display();
           
            Console.ReadKey();
        }
    }
}
