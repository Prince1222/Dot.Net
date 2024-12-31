using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double month;
            Console.WriteLine("Write the number of months");
            month = Convert.ToDouble(Console.ReadLine());   

            switch(month)
            {
                case 1: Console.WriteLine("Baisakh");
                    break;
                    case 2: Console.WriteLine("Jestha");
                    break;
                case 3: Console.WriteLine("Asadh");
                    break;
                    case 4: Console.WriteLine("Sharwan");
                    break;
                    case 5: Console.WriteLine("Bhadra");
                    break;
                    case 6: Console.WriteLine("Asoj");
                    break;
                case 7: Console.WriteLine("Kartik");
                    break;
                    case 8: Console.WriteLine("Mangsir");
                    break;
                case 9: Console.WriteLine("Poush");
                    break;
                case 10: Console.WriteLine("Magh");
                    break;
                case 11:Console.WriteLine("Fagun");
                    break;
                case 12: Console.WriteLine("Chaitra");
                    break;
                    default: Console.WriteLine("Invalid month");
                    break;
            }
        Console.ReadKey();
        }
    }
}
