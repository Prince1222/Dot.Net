using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    public delegate int MyDelegate(int x);

    internal class Delegate
    {
        public int MyMethod(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Delegate d = new Delegate();
            int res = d.MyMethod(6);
            Console.WriteLine("The result is "+res);
            int ros = d.MyMethod(128);
            Console.WriteLine("The result is " + ros);
            Console.ReadKey();
        }
    }
}
