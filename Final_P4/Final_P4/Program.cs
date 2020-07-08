using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_P4.Clases;

namespace Final_P4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 4, 6, 8, 3, 1, 7, 2 };

            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            SelectionSort.selectionSort(arr);

            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            string[] word = { "hola", "adios", "elefante", "delfin", "hoz" };

            foreach (string x in word)
            {
                Console.WriteLine(x);
            }

            SelectionSortG.selectionSort(word);

            foreach (string x in word)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
