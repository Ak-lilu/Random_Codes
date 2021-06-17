using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
   public class GuthrieIndex
    {
        public int guthrieIndex(uint n)
        {
            int count = 0;
            if (n == 1) return 1;
            if (n > 1)
            {
                do
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        count++;
                    }
                    else
                    {
                        n = n * 3 + 1;
                        count++;
                    }
                } while (n != 1);
            }
            return count;
        }
    }
}
