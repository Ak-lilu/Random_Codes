using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class Cluster
    {
        public int[]  ClusterCompression(int[] array)
        {
            List<int> list = new List<int>();
            if(array.Length > 0) { 
            int start = array[0];
            // {0, 0, 0, 2, 0, 2, 0, 2, 0, 0} 
            list.Add(start);
                for (int i = 0; i < array.Length; i++)
                {
                
                    if (start != array[i])
                    {
                        start = array[i];
                        list.Add(start);
                    }

                }
            }
            return list.ToArray();
        }
    }
}
