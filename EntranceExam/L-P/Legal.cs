
using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Legal
    {
         int IsLegalNumbers(int[] array, int base_num)
        {
            // (2 * 30) +(1 * 31) + (1 * 32) = 2 + 3 + 9 = 1410
   
            foreach (var item in array)
            {
                if (item < 0 || item > base_num)
                {
                    return 0;
                }
               
            }
            return 1;
        }
    }
}
