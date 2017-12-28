using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest18
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(val);
                    val++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
