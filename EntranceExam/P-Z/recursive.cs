using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class recursive
    {
        static int[] reversingArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
        static int Fibonacci(int num)
        {
            if (num <= 2)
                return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        static float Power(float num, int tothepower)
        {
            if (tothepower == 1)
                return num;
            return num * Power(num, tothepower - 1);
        }
        static int recur(int num)
        {
            if (num == 1)
                return num;
            return num + 3 * recur(num - 1);
        }
        static int Factorial(int number)
        {
            if (number == 1)
                return 1;
            return number * Factorial(number - 1);
        }
        static int poww(int num, int exp)
        {
            int final = 1;
            for (int i = exp; i > 0; i--)
            {
                final *= num;
            }
            return final;
        }
    }
}
