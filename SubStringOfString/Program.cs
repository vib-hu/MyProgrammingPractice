using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringOfString
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] arr= GetSubstrings("hello");

           foreach (string str in arr)
           {
               Console.WriteLine(str);
           }
            Console.ReadLine();
        }

        public static string[] GetSubstrings(string S)
        {
            int sCounter = 0;
            int eCounter = 0;
            List<string> str = new List<string>();
            for (int i = 0; i < S.Length; i++)
            {
                sCounter = 0;
                eCounter = eCounter + 1 + i;
                str.Add(S[i].ToString());
                while (sCounter < S.Length & eCounter < S.Length)
                {
                    str.Add(S.Substring(sCounter,(eCounter-sCounter)+1));
                    sCounter++;
                    eCounter++;
                }
                eCounter = 0;
            }
            return str.ToArray();
        }
    }
}
