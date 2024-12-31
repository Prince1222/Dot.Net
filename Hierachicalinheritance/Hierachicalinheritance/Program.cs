using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierachicalinheritance
{
    class Program
    {
        public int dial1, dial2;
        public void ReadDimension(int dial1, int dial2)
        {
            this.dial1 = dial1;
            this.dial2 = dial2;
        }
    }
    class Rectangle : Program
    {
        public void AreaRec()
        {
            base.ReadDimension(10,30);
            int area = base.dial1 + base.dial2;
            Console.WriteLine("Area of Rectangle is = " + area);
        }
    }
    class Traingle : Program
    {
        public void AreaTri()
        {
            base.ReadDimension(10, 40);
            double area = 0.5 * base.dial1 * base.dial2;
            Console.WriteLine("Area of traingle is = " + area);
        }
    }
    internal class Program2
    {
        static void Main(string[] args)
        {
            Traingle t = new Traingle();
            t.AreaTri();
            Rectangle r = new Rectangle();
            r.AreaRec();
            Console.ReadLine();
            
        }
    }
}
