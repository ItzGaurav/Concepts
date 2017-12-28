using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(Convert.ToChar(Convert.ToInt32('A')+j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
