/* Given an array of positive integers. All numbers occur an even number of times except one number which occurs 
an odd number of times. Find the number in O(n) time & constant space.

Examples : 

Input : arr = {1, 2, 3, 2, 3, 1, 3}
Output : 3

Input : arr = {5, 7, 2, 7, 5, 2, 5}
Output : 5
*/
using System;
using System.Collections.Generic;

namespace NumberOccuringOddTimes
{
    class NumberOccuringOddTimes
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 3, 1, 3 };
            Console.WriteLine($"Number occuring odd number of times: {GetOddOccurance(arr)}");
        }

        private static int GetOddOccurance(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(int num in arr)
            {
                if (dict.ContainsKey(num)) dict[num] += 1;
                else dict.Add(num, 1);
            }
            foreach (var num in dict)
            {
                if (num.Value % 2 != 0) return num.Key;
            }
            return 0;
        }
    }
}
