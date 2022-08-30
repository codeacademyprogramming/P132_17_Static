using System;
using System.Collections.Generic;
using System.Text;

namespace _30082022
{
    internal class Human
    {
        static Human()
        {
            Count = 10;
        }
        public static int Count;
        public Human()
        {
            Count++;
        }
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
            }
        }

        public static bool CheckName(string name)
        {

            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
                return false;

            for(int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                    return false;
            }

            return true;
        }


    }
}
