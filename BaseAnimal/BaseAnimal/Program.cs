using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAnimal
{
    public class Animal
    {
       public  string color = "black";

    }
    public class Dog:Animal {
        public string color = "white";
        public void message()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.message();
            Console.ReadKey();
        }
    }
}
