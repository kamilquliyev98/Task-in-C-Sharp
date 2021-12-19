using System;
using System.Collections.Generic;
using System.Text;

namespace Practise3
{
    class Calculator
    {
        public int Calculate(int[] arr)
        {
            int xyz = 0;
            int others = 0;

            foreach (int item in arr)
            {
                if ((item >= 100 && item <= 999) || (item <= -100 && item >= -999))
                {
                    xyz += item;
                }
                else
                {
                    others += item;
                }
            }
            return xyz - others;
        }
    }
}
