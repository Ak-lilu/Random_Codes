using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Swap
    {
        public void Sorting()
        {
            Random random = new Random();
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 101);
            }
            Console.WriteLine(string.Join(",",array));
        }
    }
}
