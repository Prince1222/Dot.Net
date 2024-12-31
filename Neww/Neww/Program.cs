using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neww
{
    public class methodoveridding
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int add(int a ,int b,int c)
        {
            return a + b + c;
        }
        public int add(int a ,int b,int c,int d)
        {
            return a + b + c + d;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            methodoveridding mo = new methodoveridding();
            int sum = mo.add(1,2);
            int fig = mo.add(1,2,4);
            Console.WriteLine("sum "+sum);
            Console.WriteLine("sum " + fig);
            Console.ReadKey();
            
        }
    }
    }

