using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOtherStringContainsPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstStr = "abbc";
            string secondStr = "dacbdbabcbbdd";

            Dictionary<int, int> dic = new Dictionary<int, int>();
            var firstStrLen = firstStr.Length;

            for (int i = 0; i < firstStr.Length; i++)
            {
                var val = (int)firstStr[i];
                if (dic.ContainsKey(val))
                {
                    dic[val] = dic[val] + 1;
                }
                else
                {
                    dic[val] = 1;
                }
            }

            Dictionary<int, int> copy = new Dictionary<int, int>(dic);

            var flag = 0;
            //for (int j = 0; j < firstStr.Length; j++)
            //{
            //    var val = (int)firstStr[j];
            //    if (dic.ContainsKey(val) && (dic[val] != 0))
            //    {
            //        dic[val] = dic[val] - 1;
            //    }
            //    else
            //    {
            //        flag = 0;
            //        break;
            //    }
            //}
            var tempLength = 0;
            for (int j = 0; j < secondStr.Length; j++)
            {
                var val = (int)secondStr[j];
                if (copy.ContainsKey(val) && (copy[val] != 0))
                {
                    tempLength++;
                    copy[val] = copy[val] - 1;
                    if (tempLength == firstStrLen)
                    {
                        flag = 1;
                        break;
                    }
                }
                else
                {
                    copy = new Dictionary<int, int>(dic);
                    tempLength = 0;
                    continue;
                }
            }


            if (flag == 0)
            {
                Console.WriteLine("Second string does't contains all permutation of first string");
            }
            else
            {
                Console.WriteLine("Second string contains all permutation of first string");
            }

            Console.ReadLine();
        }
    }
}
