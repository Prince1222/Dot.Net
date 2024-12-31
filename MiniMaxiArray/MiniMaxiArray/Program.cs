using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, i, biggest, smallest;
            int[] a = new int[100];
            Console.WriteLine("Enter the size of array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements into an array:");
          for(i =0; i < n; i++) {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            biggest = a[0];
            smallest = a[0];
            for (i = 0; i <n; i++)
            {
                
                if (a[i] > biggest)
                {
                    biggest = a[i];
                }
               if  (a[i] < smallest)
                {

                    smallest = a[i];
                }
             

            }
            
            Console.WriteLine("The biggest element is=" + biggest);
            Console.WriteLine("The smallest element is=" + smallest);
           
            Console.ReadKey();
        }
    
        
    }
}
