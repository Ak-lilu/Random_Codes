

using System;
using System.Collections.Generic;

namespace EntranceExam
{

       public class PrimeNumbers
        {
            //spoj prime generator
            //accept range


            public static void primeGenerator()
            {
                // List<int> list = new List<int>();
                int times = int.Parse(Console.ReadLine());
               
                while (times != 0) {
                    //Console.WriteLine("Enter ..");
                    string input = Console.ReadLine();
                    string[] array = input.Split(' ');
                    int start = int.Parse(array[0]);
                    int end = int.Parse(array[1]);
                    for (int i = start; i <= end; i++)
                        {
                            if (FindFactors(i).Count == 2)
                            {
                                // list.Add(i);
                                Console.WriteLine(i);
                            }
                        }
                    times--;
                } 
            }
            private static List<int> FindFactors(int thevalue)
            {
                List<int> list = new List<int>();
                if (thevalue < 2) return list;
                if (thevalue % 2==0) return list;
                int mid = thevalue ;
               
                for (int i = 1; i <= mid; i++)
                {
                    if (thevalue % i == 0)
                    {
                        list.Add(i);
                    }
                }
                return list;
            }
            int primeCount(int start, int end)
            {
                int counter = 0;


                for (int i = start; i <= end; i++)
                {
                    List<int> nums = FindFactors(i);
                    if (nums.Count == 1)
                    {
                        Console.WriteLine(i);
                        counter++;
                    }
                }
                return counter;
            }

            bool isPrime(int number)
            {
                if (number < 2) return false;
                if (number == 2) return false;
                if (number % 2 == 0) return false;
                for (int i = 3; i * i < number; i+=2)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

        }
    }

