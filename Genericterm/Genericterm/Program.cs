using System;

namespace Genericterm
{
    internal class Program
    {
       static void swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

        }

        static void Main(string[] args)
        {
            int a = 40, b = 60;
            Console.WriteLine($"Before swap {a} {b}");
           //onsole.WriteLine("Before swap: {a},{b}");
            swap<int>(ref a, ref b);
            Console.WriteLine($"AFter swap{a} {b}");
            Console.ReadKey();
        }
    }
}
