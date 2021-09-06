/* Find the sum of contiguous subarray within a one-dimensional array of numbers that has the largest sum.
Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
*/
using System;

namespace LargestSumContiguousSubarray
{
    class LargestSumContiguousSubarray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine($"Largest sum of contiguous subarray : {GetLargestSumSubarray(arr)}");
        }

        private static int GetLargestSumSubarray(int[] arr)
        {
            int arrLen = arr.Length;
            int maxSum = int.MinValue;
            int tempSum = 0;

            for (int i = 0; i < arrLen; i++)
            {
                for (int j = i; j < arrLen; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > maxSum) maxSum = tempSum;
                }
                tempSum = 0;
            }
            return maxSum;
        }
    }
}
