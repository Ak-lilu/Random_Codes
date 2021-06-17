using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntranceExam
{
    public class SumSafe
    {
        public int issumSafe(int[] array)
        {
            var sum = array.Sum();
            if (array.Contains(sum))
            {
                return 0;
            }
            return 1;
        }
    }
}
