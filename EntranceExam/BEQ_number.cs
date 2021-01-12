using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    public class BEQ_number
    {
        public int findSmallestBEQ()
        {
            int value = 0;
            int number = 19;
            while (value != 4)
            {
                int result = number * number * number;
                value = containsFoursixes(result);
                if (value == 4)
                {
                    break;
                }
                number++;
                value = 0;
            }
                return number;
        }
        int containsFoursixes(int n)
        {
            int count = 0;

            while(n != 0)
            {
                int remainder = n % 10;
                if(remainder == 6)
                {
                    count++;
                }
                n /= 10;
            }
            return count;
        }
        public int zerLimited(int[] a)
        {
            if (a.Length < 2) return 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (3 * i + 1 < a.Length) {
                    if (a[3 * i + 1] != 0 )
                    {
                        return 0;
                    }
                }
              
            }
            return 1;
        }
    }
}
