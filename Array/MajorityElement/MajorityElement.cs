/* Write a function which takes an array and prints the majority element (if it exists), otherwise prints 
“No Majority Element”. A majority element in an array A[] of size n is an element that appears more than n/2 
times (and hence there is at most one such element). 

Examples : 

Input : {3, 3, 4, 2, 4, 4, 2, 4, 4}
Output : 4
Explanation: The frequency of 4 is 5 which is greater than the half of the size of the array size. 

Input : {3, 3, 4, 2, 4, 4, 2, 4}
Output : No Majority Element
Explanation: There is no element whose frequency is greater than the half of the size of the array size.
*/
using System;
using System.Collections.Generic;

namespace MajorityElement
{
    class MajorityElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 4, 2, 4, 4, 2, 4 };
            Console.WriteLine($"Majority element is {FindMajorityElement(arr)}");
        }

        private static string FindMajorityElement(int[] arr)
        {
            int arrLen = arr.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item)) dict[item] += 1;
                else dict.Add(item, 1);
                if (dict[item] > arrLen / 2) return Convert.ToString(item) + ".";
            }
            return "not found.";
        }
    }
}
