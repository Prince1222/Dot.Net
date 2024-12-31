using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cp,sp,result;
            Console.WriteLine("ENter the Cost Price");
            cp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter the Selling Price");
            sp = Convert.ToInt32(Console.ReadLine());

            if(sp>cp)
            {
                result = sp - cp;
                Console.WriteLine("Profit amount "+result);
                
            }
            else if(cp>sp)
            {
                result = cp - sp;
                Console.WriteLine("Loss amount " + result);
            }
            else { Console.WriteLine("Equal no gain no loss");
            
            }
            Console.ReadKey();
        }
    }
}
