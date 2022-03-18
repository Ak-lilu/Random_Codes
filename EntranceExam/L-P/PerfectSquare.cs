using System;

namespace EntranceExam
{

        class PerfectSquare
        {
            // 5 2.14234 9 : 7 = 2.645345 9
            int isPerfectSquare(int n)
            {
                if (n < 0) return 0;
                var init = (int)Math.Sqrt(n);
                init++;
                return init * init;
            }
        }
    }
