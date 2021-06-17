using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Hollow
    {
        int isHollow(int[] HollowArray)
        {
            int Hollow = 0;
            int count = 0, numberofZeroes = 0, afterzeroes = 0;
            for (int i = 0; i < HollowArray.Length; i++)
            {
                if (HollowArray[i] != 0)
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            for (int i = count; i < HollowArray.Length; i++)
            {
                if (HollowArray[i] == 0)
                {
                    numberofZeroes++;
                }
                else
                {
                    break;
                }
            }
            var leftover = numberofZeroes + count;
            // Console.WriteLine(leftover);
            for (int i = numberofZeroes + count; i < HollowArray.Length; i++)
            {

                if (HollowArray[i] == 0)
                {
                    //break;
                    return Hollow;

                }
                else
                {
                    afterzeroes++;
                }
            }
            if (numberofZeroes > 2 && count == afterzeroes)
            {
                Hollow = 1;
                return Hollow;
            }
            return Hollow;
        }
    }
}
