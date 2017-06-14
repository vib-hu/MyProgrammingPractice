using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaindromPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Check = "Tact coato";
            Check = Check.ToLower();
            Check = Check.Replace(" ", "");

            Dictionary<int, int> dic = new Dictionary<int, int>();

            int oddFlag = 0;
            foreach (char ch in Check)
            {
                var val = (int)ch;

                if (dic.ContainsKey(val))
                {
                    dic[val] = dic[val] + 1;
                }
                else
                {
                    dic[val] = 1;
                }

                if (dic[val] % 2 == 1)
                {
                    oddFlag++;
                }
                else
                {
                    oddFlag--;
                }

            }
           
            //foreach (int key in dic.Keys)
            //{
            //    if (dic[key] % 2 == 0)
            //    {

            //    }
            //    else
            //    {
            //        flag++;
            //    }
            //}

            //if (Check.Length % 2 == 0 && flag > 0)
            //{
            //    Console.WriteLine("No plaindrome permutation");
            //}
            //else if (Check.Length % 2 != 0 && flag != 1)
            //{
            //    Console.WriteLine("No plaindrome permutation");
            //}
            //else
            //{
            //    Console.WriteLine("string one permutation is plaindrom");
            //}

            Console.ReadLine();
        }
    }
}
