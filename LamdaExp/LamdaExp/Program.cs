using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExp
{
    internal class Program
    {
        
        
            static int test() => 5;
        static int  test2(int x) => x + 10;
        static void Main(string[] args)
        {
            int x = test();
            int res = test2(x);
            Console.WriteLine("The resukt is="+res);
            Console.ReadKey();
        }

    }
    }

