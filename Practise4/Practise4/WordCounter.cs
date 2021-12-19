using System;
using System.Collections.Generic;
using System.Text;

namespace Practise4
{
    class WordCounter
    {
        public int Count(string str)
        {
            string[] arr = str.Split(' ');
            return arr.Length;
        }
    }
}
