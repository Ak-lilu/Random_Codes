namespace EntranceExam
{
    class EvenOddDifference
    {
        int EvenMinusOdd(int[] arr)
        {
            int even = 0, odd = 0, final = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += arr[i];
                }
                else
                {
                    odd += arr[i];
                }
                final = odd - even;
            }
            return final;
        }
    }
}
