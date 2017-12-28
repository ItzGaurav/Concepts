using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 8, 9, 1 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
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
