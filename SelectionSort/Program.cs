using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8,9, 5, 4, 3, 2, 1 };
            SelectionSort(arr);
        }

        public static void SelectionSort(int[] arr)
        {
            int min;
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                min = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = min;
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
                Console.WriteLine("\n");
            }

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
            Console.ReadLine();
        }
    }
}
