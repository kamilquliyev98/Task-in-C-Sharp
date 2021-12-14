using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        public void ReverseStr(string str)
        {
            string[] arr = str.Split(' ');

            string result = string.Empty;

            foreach (string item in arr)
            {
                for (int i = item.Length -1; i >= 0; i--)
                {
                    result += item[i];
                }

                if (result.Length < str.Length)
                {
                    result += " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
