using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    internal class Program
    {
        class IndexerClass
        {
            private string[] names = new string[7];
            public string this[int i]
            {
                get
                {
                    return names[i];
                }
                set
                {
                    names[i] = value;
                }
            }
        }
        static void Main(string[] args)
     {
    IndexerClass week = new IndexerClass();
    week[0] = "Sunday";
    week[1] = "Monday";
    week[2] = "Tuesday";
    week[3] = "Wednesday";
    week[4] = "Thursday";
    week[5] = "Friday";
    week[6] = "Saturday";
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine(week[i]);
                
            }
            Console.ReadKey();
        }
}
}
