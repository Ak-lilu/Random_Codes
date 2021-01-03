using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Sample
    {
        private static void Tree()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k * k);
                }
                Console.WriteLine();
            }
        }
    }
}
