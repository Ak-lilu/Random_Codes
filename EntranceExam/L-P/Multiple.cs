using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class Multiple
    {
        //let assume n = 4
        public int smallest(int n)
        {
            int number = 1;
            int count = 0;
            while(count != n)
            {
                number++;
                count = 0;
                for (int i = 1; i <= n; i++)
                {
                   
                    int result = number * i;
                    if (containsTwo(result))
                    {
                        count++;
                    }
                    else
                    {
                        i = n;
                    }
                }
               
            }
            return number;
        }

        private static bool containsTwo(int number)
        {
            bool cont = false;

            while (number != 0)
            {
                int remainder = number % 10;

                if (remainder == 2)
                {

                    cont = true;
                    return cont;
                }
                number = number / 10;
            }

            return cont;
        }
    }
}
