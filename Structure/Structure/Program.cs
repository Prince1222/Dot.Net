using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct book
    {
        public string book_title;
        public string author;
        public int page;
        public float price;
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1;
            b1.book_title = "Dot Net Technology";
            b1.author = "Anik Maharjan";
            b1.page = 1;
            b1.price = 500;
            Console.WriteLine("Name of the book:(0)", b1.book_title);
            Console.WriteLine()
        }
    }
}
