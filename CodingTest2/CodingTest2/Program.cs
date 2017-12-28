using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest2
{
    //this keyword use for Reference to current instance of class
    class A
    {
        string name, address;
        public void show(string name, string address)
        {
            this.name = name;
            this.address = address;
            Console.WriteLine(name + " " + address);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.show("Gaurav", "Noida ");
            A o = new A();
            o.show("John", "UK");
            Console.ReadKey();
        }
    }
}
