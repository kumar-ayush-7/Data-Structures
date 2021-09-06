/* You are given a list of n-1 integers and these integers are in the range of 1 to n. There are no duplicates 
in the list. One of the integers is missing in the list. Write an efficient code to find the missing integer.

Example: 

Input: arr[] = {1, 2, 4, 6, 3, 7, 8}
Output: 5
Explanation: The missing number from 1 to 8 is 5

Input: arr[] = {1, 2, 3, 5}
Output: 4
Explanation: The missing number from 1 to 5 is 4
*/
using System;

namespace FindMissingNumber
{
    class FindMissingNumber
    {
        static void Main(string[] args)
        {
            int[] testArr = new int[] { 1, 3 };
            Console.WriteLine($"Missing number : {GetMissingNumber(testArr)}");
        }

        private static int GetMissingNumber(int[] arr)
        {
            double arrLen = arr.Length;
            // since we are getting n - 1 integers, arithmetic sum will be done for arraylength + 1 items.
            double totalSum = (arrLen + 1) / 2 * (1 + arrLen + 1);
            for (int i = 0; i < arrLen; i++)
            {
                totalSum -= arr[i];
            }
            return (int)totalSum;
        }
    }
}
