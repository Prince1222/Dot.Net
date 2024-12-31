using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMethod
{
    public delegate void DelEventHandler();
    internal class Program
    {
        public static event DelEventHandler  add;
        static void FZ()
        {
            Console.WriteLine("This is a naked sports");
        }
        static void CRF()
        {
            Console.WriteLine("This is a dirt segment");
        }
        static void RC()
        {
            Console.WriteLine("This is a fully sport segment");
        }
        static void Main(string[] args)
        {
            add += new DelEventHandler(FZ); //subscribe
            add += new DelEventHandler(CRF);
            add += new DelEventHandler(RC);
            add -= new DelEventHandler(RC);//unsubscribe
            add.Invoke();
            Console.ReadKey();
        }
    }
}
