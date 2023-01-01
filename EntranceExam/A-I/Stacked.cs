using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam.A_I
{
    public class Stacked
    {
        public static int IsStacked(int number)
        {
            bool stacked = false;
            int init = 1;
            while (number - init >= 0)
            {
                number -= init;
                if (number == 0)
                {
                    stacked = true;
                } 
                init++;
            }
            return stacked ? 1 : 0;

        }
    }
}
