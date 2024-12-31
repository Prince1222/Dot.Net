using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    internal class ConsDes
    {
       
    public ConsDes(string message) {
        Console.WriteLine(message);
        }
        public void Test()
        {
            Console.WriteLine("This is a method");
        }
        ~ConsDes()
        {
            Console.WriteLine("This is a Destructor");
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            string message = "This is a message";
            ConsDes cd = new ConsDes(message);
            cd.Test();
            
        }
    }
}
