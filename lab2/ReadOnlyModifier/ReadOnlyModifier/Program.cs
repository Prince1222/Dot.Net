using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadOnlyModifier
{
    class Zoe
    {
        public readonly string str1;
        public readonly  string str2;

        public readonly string str3 = "DOtNet";

        public coco(string a,string b)
        {
            str1 = a;
            str2 = b;
            Console.WriteLine("displaying the value of string {0},"+"and string 2 {1}",str1,str2);
        }
        
        
        
    }

        
        static void Main(string[] args)
        {
        Zoe z = new Zoe();
        z.coco("good", "pet");
           

        }
    }

