using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int ret = 0;
            foreach(char ch in str)
            {
                if (ch == letter)
                    ret ++;
            }
            return ret;
        }
    }
}
