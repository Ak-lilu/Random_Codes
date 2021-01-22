using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntranceExam
{
    public class EntranceExam
    {
        public int is123Array(int[] a)
        {
            // not enough
            if (a.Length % 3 != 0) return 0;
            // empty array
            if (a.Length == 0) return 0;
            for (int i = 0; i < a.Length; i += 3)
            {
                // check {1,2,3}
                if (a[i] != 1 || a[i + 1] != 2 || a[i + 2] != 3)
                {
                    return 0;
                }
            }
            return 1;
        }
        public  int isMercurial(int[] array)
        {

            bool Flag = false;

            int three = -1;
            int one = -1;
            for (int i = 0; i < array.Length; i++)
            {
                // give index for one
                if (array[i] == 1)
                {
                    one = i;
                }
                // give index for three
                if (array[i] == 3)
                {
                    three = i;
                }
                // if both are found and one is behind three,
                // change the bool value
                if (one != -1 && three > one)
                {
                    Flag = true;
                }
                   
                // if upper condition met find for another 1
                if (Flag && array[i] == 1)
                {
                    return 0;
                }
                    
            }

            return 1;
        }
    
         public  int isOnionArray(int[] array)
        {
            for (int i = 0; i < (array.Length) / 2; i++)
            {

                for (int j = array.Length - 1 - i; j >= (array.Length + 1) / 2; j--)
                {
                    if (array[i] + array[j] > 10)
                        return 0;
                }
            }

            return 1;
        }
        public int theNextBig(int[] n)
       {
          if(n.Length < 2)
            {
                return -1;
            }
          if(n.Distinct().Count() == 1)
            {
                return -1;
            }
            int max = n.Max();
           List<int> mm = n.Where(x => x != max).ToList();
            return mm.Max();
       }
        //public static int isOnion(int[] a)
        //{
        //    int at = 9;
        //    for (int i = 0; i < a.Length/2; i++)
        //    {
        //        for (int o = a.Length-1; o < (a.Length+1)/2; o--)
        //        {
        //            if (i >= 0)
        //            {
        //                Console.WriteLine("i : " + i + " o :" + o);
        //            }
        //        }
        //       // return i;
        //    }
        //    if (at < 9)
        //    {
        //        return 9;
        //    }
           
        //}







    }
}
