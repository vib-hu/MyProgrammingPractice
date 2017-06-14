using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpaceWith20
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "Mr John Smith";
            var charArr = str.ToCharArray();
            char[] arr1 = new char[30];
            charArr.CopyTo(arr1, 0);
            var intSpaceCount = SpaceCount(arr1);

            var index = str.Length + intSpaceCount * 2;
            index = index - 1;
            for (int i = str.Length-1; i > 0; i--)
            {
                if (arr1[i] == ' ')
                {
                    arr1[index] = '0';
                    arr1[index - 1] = '2';
                    arr1[index - 2] = '%';
                    index = index - 3;

                }
                else
                {
                    arr1[index] = arr1[i];
                    index--;
                }
            }

            foreach (char r in arr1)
            {
                Console.Write(r);
            }

            Console.ReadLine();
        }

        static int SpaceCount(char[] arr)
        {
            int spaceCount = 0;
            foreach (char r in arr)
            {
                if (r == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }
    }
}
