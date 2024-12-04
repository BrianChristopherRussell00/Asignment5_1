using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment5_1
{
    public class CheckPalindrome
    {
        public static bool checkPalindrome(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len - i - 1])
                {
                    return false;
                }
                return true;
            }
            return false;
        }


    }
}
