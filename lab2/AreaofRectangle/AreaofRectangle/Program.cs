using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofRectangle
{
    internal class Area
    {
        double length;
        double breadth;
        
        double rectangle()
        {
            return length * breadth;
        }
        void set(double l,double b)
        {
             length=l;
            breadth =b;

        }
       
        class Box { 
        static void Main(string[] args)
        {
                Area a = new Area();
                Area a2 = new Area();

                double vol;
                a.set(10, 30);
                a2.set(10.30, 12.22);
                vol = a.rectangle();
                Console.WriteLine("Area of Rectangle:" + vol);
                vol = a2.rectangle();

                Console.WriteLine("Area of Rectangle:" + vol);
                Console.ReadKey();

        }
    }
}
}