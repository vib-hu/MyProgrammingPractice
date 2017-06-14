using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 5, 4, 3, 2, 1 };
            BubbleSort(arr);
        }

        public static void BubbleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                    foreach (var item in arr)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine(i+" traversal");
            }
            Console.ReadLine();
        }
    }
}
