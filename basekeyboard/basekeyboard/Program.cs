using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basekeyboard
{
    class Base
    {
        public Base(int a,int b,int c)
        {
            Console.WriteLine("The value of a ={0} ,b ={1} and c={2}", a, b,c);
        }
    }
    class Derived : Base
    {
        public Derived(int x, int y,int z) : base(x, y,z)
        {
            Console.WriteLine("The value of x={0}, y={1} and z={2} ", x, y, z);
        }
    }
  
    internal class Program
    {
        class BaseEx
        {

      
        static void Main(string[] args)
        {
                new Derived(10, 20,30);
                Console.ReadKey();
        }
    }
}
}
