using System;
using System.Collections.Generic;
using System.Text;

namespace _30082022
{
    internal static class Calculator
    {
        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Pow(int num1,int num2)
        {
            int sum = 1;
            while (num2>0)
            {
                sum *= num1;
                num2--;
            }

            return sum;
        }
    }
}
