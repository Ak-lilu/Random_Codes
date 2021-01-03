using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Square
    {
        int isSquare(int n)
        {
            int Square = 0;
            double root = Math.Sqrt(n);
            if ((int)root * (int)root == n)
            {
                Square = 1;
                return Square;
            }
            return Square;
        }
    }
}
