using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // For First Outpot
                   // Console.Write(j);  // For Second Output
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
