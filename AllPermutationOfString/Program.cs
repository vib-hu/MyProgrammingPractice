using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPermutationOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "ABC";

            int n = str.Length;
            Permute(str, 0, n - 1);
            Console.ReadLine();
        }

        private static void Permute(string str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i); 
                    Permute(str, l + 1, r); 
                    str = Swap(str, l, i);
                }
            }
        }
        public static string Swap(string a, int i, int j)
        {
            char[] charArray = a.ToCharArray();
            var temp = charArray[j];
            charArray[j] = charArray[i];
            charArray[i] = temp;
            string s = new string(charArray);
            return s;

        }
    }
}
