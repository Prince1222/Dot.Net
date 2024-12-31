using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaryMinus
{
    class Test
    {
        int x, y, z;
        public Test(int a, int b,int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public void display()
        {
            Console.WriteLine(" " + x + " " + y + " " + z);
        }
        public static Test operator - (Test obj)
        {
            obj.x= -obj.x;
            obj.y= -obj.y;
            obj.z = -obj.z;
            return obj; 
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Test obj = new Test(10,20,30);
            Console.WriteLine("Simply object contains");
            obj.display();
            obj = -obj;
            Console.WriteLine("New object conatins:");
            obj.display();
            Console.ReadKey();
        }
    }
}
