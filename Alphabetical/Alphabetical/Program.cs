using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabetical
{
   class Program
    {
        static void Main(string[] args)
        {
            Líst<string> names = new List<string>()
            names.Add("anik");
            names.Add("sunita"); ;
            names.Add("krishal");
            names.Add("pradeep");
            names.Add("krishna");
            names.Add("ayush");
            names.Add("sijan");
            names.Sort();
            foreach(string n in names)
            {
                Console.WriteLine(n);
                Console.ReadLine();
            }
            Console.ReadKey();

        }
    }
}
