using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPairsWithGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,1, 5, 7, -1, 5 };
            int intArrLenghth = arr.Length;
            int sum = 6;
            var res = GetCountpairsWithGivenSum1(intArrLenghth, sum, arr);
            Console.Write(res);
            Console.ReadLine();
        }


        //(O)n2 solution
        public static int GetCountpairsWithGivenSum(int ArrLength, int Sum, int[] arr)
        {
            var pairCount = 0;
            for (int i = 0; i < ArrLength; i++)
            {
                for (int j = i + 1; j < ArrLength; j++)
                {
                    if (arr[i] + arr[j] == Sum)
                    {
                        pairCount++;
                    }
                }
            }
            return pairCount;
        }

        //(O)n solution
        public static int GetCountpairsWithGivenSum1(int ArrLength, int Sum, int[] arr)
        {
            int pairCount = 0;
            int twiceCount = 0;

            Dictionary<int, int> itemCount = new Dictionary<int, int>();
           
            for (int i = 0; i < arr.Length; i++)
            {
                itemCount[arr[i]] = (itemCount.ContainsKey(arr[i]) ? itemCount[arr[i]]: 0) + 1;
            }
           
            for (int i = 0; i < arr.Length; i++)
            {
                twiceCount = twiceCount + (itemCount.ContainsKey(Sum - arr[i])?itemCount[Sum-arr[i]]:0);

                if (Sum - arr[i] == arr[i])
                {
                    twiceCount--;
                }
            }
            return twiceCount / 2;
        }
    }
}
