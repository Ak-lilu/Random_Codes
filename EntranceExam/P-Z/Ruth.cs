using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class Ruth
    {
        public void main()
        {
            // a very simple bsc 1st
            int a = 0;
            int w = 9;
            int[] array = new int[w];
            Console.WriteLine("add elements ...");
            for (int i = 0; i < w; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine( compare(array) );
        }
        int compare(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++) 
            {
                if (array[i] > array[0])
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
