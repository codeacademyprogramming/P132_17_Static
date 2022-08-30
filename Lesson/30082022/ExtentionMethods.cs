using System;
using System.Collections.Generic;
using System.Text;

namespace _30082022
{
    internal static  class ExtentionMethods
    {
        public static int Add(this int num1,int num2)
        {
            return num1 + num2;
        }

        public static bool HasDigit(this string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i]))
                        return true;
                }
            }

            return false;
        }

        public static void ShowStudentInfo(this Student std)
        {
            Console.WriteLine(std.FullName+" - "+std.GroupNo);
        }

        public static int ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static string ToCapitalize(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            string newStr = Char.ToUpper(value[0]).ToString();

            if (value.Length > 1)
            {
                newStr = newStr + value.Substring(1).ToLower();
            }

            return newStr;
        }
    }
}
