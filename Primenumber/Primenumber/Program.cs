using System;

namespace Primenumber
{
    static void Main(string[] args)
    {
        bool IsPrime = true;
        double i, j;
        Console.WriteLine("Prime Numbers: ");
        for (i=2; i <= 100; i++)
        {
            for(j=2; j <= 100; j++)
            {
                if(i !=j && j%2 == 0)
                {
                    IsPrime = false;
                    break;
                }
                if (IsPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                IsPrime = true;
            }
            Console.ReadKey();
        }
    }
}