using System;

namespace EntranceExam
{
    partial class Program
    {
        class PerfectSquare
        {
            int isPerfectSquare(int n)
            {
                if (n < 0) return 0;
                var init = Math.Sqrt(n);
                var cast = (int)init;
                cast++;
                return cast * cast;
            }
        }
    }
}
