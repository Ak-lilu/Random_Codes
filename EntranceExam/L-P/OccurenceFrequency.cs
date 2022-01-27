using System;
using System.Linq;
namespace EntranceExam.L_P
{
    class OccurenceFrequency
    {
        public void ElementOccurenceCount(int[] mainArray)
        {
            var distinct = mainArray.ToList().Distinct();

            var dictionary = distinct.ToDictionary(x => x, x=>0);

            for (int i = 0; i < mainArray.Length; i++)
            {
                dictionary[mainArray[i]] = dictionary[mainArray[i]] + 1;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key+ " occured "+item.Value+" times.");
            }
        }
    }
}
