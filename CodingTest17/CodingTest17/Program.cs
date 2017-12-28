using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest17
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="computer";
            char[] arr=str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(arr[j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
