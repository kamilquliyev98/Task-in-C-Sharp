using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Extension
{
    static class Checker
    {
        public static bool Check(this string str, string part)
        {
            if (str.Contains(part))
            {
                return true;
            }
            return false;
        }
    }
}
