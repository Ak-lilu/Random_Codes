using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceExam
{
    public class Eratosthenes
    {
        public void sieve()
        {
            int tests = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < tests; t++)
            {
                List<int> line = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
                List<int> final = new List<int>();
                int m = line[0], n = line[1];
                for (int i = 2; i <= n; i++)
                {
                    final.Add(i);
                }
                for (int p =2; p * p <= n; p++)
                {
                        for (int i = p * p; i <= n; i += p)
                        {
                            final.Remove(i);
                        }
                }
                final = final.Where(x => x >= m).ToList();
                Console.WriteLine(string.Join(" ",final));

            }

        }
    }
}

