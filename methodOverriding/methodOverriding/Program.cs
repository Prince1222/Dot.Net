using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverriding
{
    public class Method
    {
        public  virtual int balance()
        {
            return 500;
        }
    }
    public class Method2 : Method
    {
        public override int balance()
        {
            return 5000;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Method2 mn= new Method2();
            int Amount = mn.balance();
            Console.WriteLine("The available balance is {0}", Amount);
            Console.ReadKey();
        }
    }
}
