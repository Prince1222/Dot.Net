using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformation
{

    class Person
    {
        static  Person()
        {
            Console.WriteLine("My Name is Anik Maharjan");
        }
        public Person()
        {
            Console.WriteLine("Age is 21 ");
            Console.WriteLine("Gender is Male");
        }
       static void Main(string[] args)
        {
            
            new Person();
            Console.ReadKey();
        }
    }

}   