using System;

namespace EntranceExam
{
    partial class Program
    {
        class Equilibrium
        {
            int equilibrium(int[] ff)
            {
                int sum = 0, rightSum = 0, c = 0;
                for (int i = 0; i < ff.Length; i++)
                {
                    sum += ff[i];
                }

                for (int i = ff.Length - 1; i >= 0; i--)
                {
                    sum -= ff[i];
                    Console.WriteLine("Sum : " + sum + " Right sum : " + rightSum);
                    if (sum == rightSum)
                    {
                        c = i;
                        break;
                    }
                    rightSum += ff[i];
                    if (c == 0)
                    {
                        c = -1;
                    }
                }
                return c;
            }
        }
    }
}
