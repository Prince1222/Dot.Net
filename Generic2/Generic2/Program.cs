using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class Example
    {
        public static void ShowArray<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        /*public static void ShowArray(String[] arr) {
          for(int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 12;
            number[1] = 13;
            number[2] = 14;
           
            string[] name = new string[3];
            name[0] = "Anik";
            name[1] = "Pradeep";
            name[2] = "Prince";
            Example.ShowArray(number);
            Example.ShowArray(name);
            Console.ReadKey();

        }
    }
}
