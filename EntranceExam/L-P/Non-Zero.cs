using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntranceExam
{
    public class Non_Zero
    {
        public int hasZeroes(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    return 0;
                }

            }
            return 1;
        }
    }
}
