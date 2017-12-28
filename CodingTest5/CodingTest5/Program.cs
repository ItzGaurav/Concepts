using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest5
{
    class A
    {
        protected A()   // if we craete a Protected cunstructor than we can't create object of that  class. We can access only protected/Public member by THIS keyword.  
        {
        }
        public void display()
        {
            Console.WriteLine("Display");
        }
        protected void show()
        {
            Console.WriteLine("Show");
        }
    }

    class B : A
    {
        //A aObject = new A(); // we can't create object because of Protected cunstructor
        public void ABC()
        {
            this.show();
            this.display();
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            B obj = new B();
            obj.ABC();

            Console.ReadKey();
        }
    }
}
