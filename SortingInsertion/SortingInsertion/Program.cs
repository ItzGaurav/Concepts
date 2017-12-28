using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr={5,2,7,1,8};
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
