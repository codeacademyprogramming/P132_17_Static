using System;
using System.Collections.Generic;
using System.Text;

namespace _30082022
{
    internal class Student
    {
        private static int _totalCount=0;
        private int _no;
        private string _groupNo;

        //static Student()
        //{
        //    _totalCount = 100;
        //}
        public Student()
        {
            _totalCount++;
            _no = _totalCount + 100; 
        }
        public int No => _no;
        public string FullName;
        public string GroupNo
        {
            get => _groupNo;
            set {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }

        public static bool CheckGroupNo(string no)
        {
            if (string.IsNullOrWhiteSpace(no) || no.Length != 4 || !char.IsLetter(no[0]))
                return false;

            for (int i = 1; i < no.Length; i++)
            {
                if (!char.IsDigit(no[i]))
                    return false;
            }

            return true;
        }
    }
}
