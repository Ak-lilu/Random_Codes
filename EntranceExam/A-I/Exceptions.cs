
using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class Exceptions
    {
        public void add(int a, int b)
        {
            try
            {
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Data);
            }
        }
    }
}
