using Swapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Example<Z>
    {
        Z box;
        public Example(Z b){
            this.box = b;
            }
    public Z Getbox()
    {
        return this.box;
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
        Example<int > e = new Example<int>(40);
        Example<string> e1 = new Example<string>("ram bahadur");
        Example<char> e2 = new Example<char>('S');
        Console.WriteLine(e.Getbox());
        Console.WriteLine(e1.Getbox());
        Console.WriteLine(e2.Getbox());
        Console.ReadKey();
        }
    }
}
