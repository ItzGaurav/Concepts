using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest10
{
    class test
    {
        int A, B;
        public test() // Default
        {
            A = 10;
            B = 20;
            Console.WriteLine("default constructor");
        }

        public test(int x, int y) // Perametrize
        {
            A = x;
            B = y;
            Console.WriteLine("parametrize constructor");
        }

        public test(test t)  // Copy
        {
            A = t.A;
            B = t.B;
            Console.WriteLine("copy constructor");
        }

        public void print()
        {
            Console.WriteLine("A={0} \t  B={1}", A, B);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            test t1 = new test();
            t1.print();
            test t2 = new test(100, 200);
            t2.print();
            test t3 = new test(t1);
            t3.print();

            Console.ReadKey();
        }
    }
}
