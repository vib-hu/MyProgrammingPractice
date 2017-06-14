using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 5, 4, 3, 2, 1 };
            InsertonSort(arr);
        }

        public static void InsertonSort(int[] arr)
        {
            int key = 0;
            int j = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
                Console.WriteLine("\n");
                
            }
            Console.ReadLine();
        }
    }
}
