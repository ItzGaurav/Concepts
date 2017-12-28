using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest6
{
    class A
    {
        //Override to string method to give complex type string representation to a meaningfull.
        public string FN { get; set; }
        public string LN { get; set; }
        public override string ToString()
        {
            return this.FN + this.LN;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            A obj = obj1;  // copy the object

            obj.FN = "ABC";
            obj.LN = "XYZ";
            Console.WriteLine(obj.ToString());
            Console.ReadKey();
        }
    }
}
