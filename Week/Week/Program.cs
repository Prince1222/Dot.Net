using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the name of the week");
            day= Convert.ToInt32(Console.ReadLine());
            
            switch (day)
            {
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Mondday");
                    break;
                    case 3: Console.WriteLine("Tuesday");
                    break;
                    case 4: Console.WriteLine("Wednesday");
                    break;
                case 5:Console.WriteLine("Thursday");
                    break;
                    case 6: Console.WriteLine("Friday");
                    break;
                    case 7: Console.WriteLine("Saturday");
                    break;
                    default: Console.WriteLine("Invalid value");
                    break;

            }
            Console.ReadKey();
        }
    }
}
