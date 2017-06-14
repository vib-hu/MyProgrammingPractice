using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertDeleteSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            
            arr[0]=1;
            arr[1] = 3;
            arr[2] = 5;
            arr[3] = 7;
            arr[4] = 9;
           
           var res= InsertInArry(arr,8,5,arr.Length);
           foreach (var item in res)
           {
               Console.Write(item);
           }
           Console.WriteLine("\n");
           Console.ReadLine();
        }

        //Binary search
        public static int BinarySearch(int[] Arr, int Key, int Low, int High)
        {
            if (High < Low)
                return -1;
            int mid = (Low + High) / 2;

            if (Arr[mid] == Key)
                return mid;
            if (Key > Arr[mid])
                return BinarySearch(Arr, Key, mid + 1, High);
            return BinarySearch(Arr, Key, Low, mid+1);
        }

        public static int[] InsertInArry(int[] Arr, int Key,int NOElements, int Capacity)
        {
            if (NOElements >= Capacity)
                return Arr;

            int i = 0;
            for (i = NOElements - 1;( Arr[i] > Key && i >= 0); i--)
            {
                Arr[i + 1] = Arr[i];
            }
            Arr[i + 1] = Key;
            return Arr;
        }
    }
}
