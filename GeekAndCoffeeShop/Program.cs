using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekAndCoffeeShop
{
    //http://practice.geeksforgeeks.org/problems/geek-and-coffee-shop/0
    class Program
    {
        static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            string[] arrTestCases = new string[5];
            for (int i = 0; i < testCases; i++)
            {
                arrTestCases[i] = Console.ReadLine();
            }

            for (int i = 0; i < testCases; i++)
            {
                var arrMoneyAndMth = arrTestCases[i].Split(' ');
                int rupee = Convert.ToInt32(arrMoneyAndMth[0]);
                int mthRefill = Convert.ToInt32(arrMoneyAndMth[1]);
               var res= getUnitsOfCofeeForMthRefill(rupee, mthRefill);
               Console.WriteLine(res);
            }
        }

        public static int getUnitsOfCofeeForMthRefill(int Rupee, int MthRefill)
        {
            if (MthRefill == 1)
            { return Rupee; }
           return getUnitsOfCofeeForMthRefill(Rupee / 2, MthRefill - 1);
        }
    }
}
