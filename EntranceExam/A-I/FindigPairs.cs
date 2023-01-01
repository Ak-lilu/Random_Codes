using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceExam.A_I
{
    public class FindigPairs
    {
        public IEnumerable<int> FindPairs()
        {
            List<int> mainArray = new List<int>() { 8, 7, 2, 5, 3, 1 };
            int target = 10;
            for (int i = 0; i < mainArray.Count(); i++)
            {
                for (int k = i+1; k < mainArray.Count(); k++)
                {
                    if (mainArray[k]+mainArray[i]== target)
                    {
                        Console.Write(mainArray[k] + "," + mainArray[i]);
                    }
                }
                Console.WriteLine();
            }
            return new List<int>();
        }
    }
}
