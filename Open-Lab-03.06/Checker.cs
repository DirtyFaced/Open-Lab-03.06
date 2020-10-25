using System;

namespace Open_Lab_03._06
{
    public class Checker
    {
        public bool HasSpaces(string str)
        {
            bool aaa = false;
            if (str.Contains(" "))
            { aaa = true; };
            return aaa;
        }
    }
}
