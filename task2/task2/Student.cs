using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    internal class Student
    {
        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public byte Age { get; set; }

        public static bool CheckFullName(string fullName)
        {
            string[] names= fullName.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            if(names.Length > 0 )
            {
                return false;
            }
            if (string.IsNullOrEmpty(names[0]) || string.IsNullOrEmpty(names[1]))
            {
                return false;
            }
            return true;
        }

        public static bool CheckGroupNo(int groupNo)
        {
            if (groupNo >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
