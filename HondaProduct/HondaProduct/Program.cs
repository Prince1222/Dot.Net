using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HondaProduct
{
    class Honda
    {
        public string model;
        public int year;
        public void Data(string model, int year)
        {
            this.model = model;
            this.year = year;
        }
        public void Display()
        {
            Console.WriteLine("The model of honda is= " +model );
            Console.WriteLine("The manufacture date of honda is= " + year);

        }
    }
    class Grazia : Honda
    {
        int mileage;
        string color;

        public void Des(int mileage, string color)
        {

            this.mileage = mileage;
            this.color = color;
        }
        public void Gdis() { 
           // Console.WriteLine("The model is=" + base.model  + base.year);
            Console.WriteLine("The mileage is=" + mileage+" and color is " +color);
        }
    }
    class CRF : Honda
    {
        int kerbweight;
        string ecu;
        public void Info(int kerbweight,string ecu)
        {
            this.kerbweight = kerbweight;
            this.ecu = ecu;
        }
        public void Dirt() {
            Console.WriteLine("The bike one of latest " + base.model +" and manufacture in " + base.year);
            Console.WriteLine("The kerb weight of bike  " + kerbweight+" and have ecu is " +ecu);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         CRF h = new CRF();
            h.Data("newgen",2024);
            h.Display();
            h.Info(143, "no");
            h.Dirt();

            Grazia  g = new Grazia();
            g.Des(45, "blue");
            g.Gdis();
            Console.ReadKey();

        }
    }
}
