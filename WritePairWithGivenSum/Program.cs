using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritePairWithGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 5, 7, -1, 5 };
            int sum = 6;

            GetpairsForGivenSum(arr, sum);
            Console.ReadLine();
        }
        public static void GetpairsForGivenSum(int[] Arr, int Sum)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < Arr.Length; i++)
                dictionary[Arr[i]] = (dictionary.ContainsKey(Arr[i]) ? dictionary[Arr[i]] : 0) + 1;

            for (int i = 0; i < Arr.Length; i++)
            {
                var val = dictionary.ContainsKey(Sum - Arr[i]) ? dictionary[Sum - Arr[i]] : 0;
                if (val > 0)
                {
                    for (int j = 0; j < val; j++)
                    {
                        Console.WriteLine(Sum - Arr[i] + "," + Arr[i]);
                    }
                    dictionary[Arr[i]] = 0;
                }
            }
        }
    }
}
