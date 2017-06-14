using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElelmentsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };

            var res = GetMajorityElements(arr);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        public static int  GetMajorityElements(int[] Arr)
        {
            Dictionary<int,int> dictionary= new Dictionary<int,int>();
            for (int i = 0; i < Arr.Length; i++)
                dictionary[Arr[i]] = (dictionary.ContainsKey(Arr[i]) ? dictionary[Arr[i]] : 0)+1;

            foreach (var Key in dictionary.Keys)
            {
                if (dictionary[Key] > (Arr.Length / 2))
                    return Key;
            }
            return 0;
        }
    }
}
