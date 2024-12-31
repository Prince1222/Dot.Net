using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[][]
{
new int[] {1,2},
new int[] {1, 2, 3},
new int[] {1, 2, 3, 4}
};
            foreach (int[] array in jagged)
            {
                foreach (int e in array)
                {
                    Console.Write("\t" + e);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
