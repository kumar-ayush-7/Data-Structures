/* Given an array of positive numbers, find the maximum sum of a subsequence with the constraint that no 2 
numbers in the sequence should be adjacent in the array. So 3 2 7 10 should return 13 (sum of 3 and 10) or 
3 2 5 10 7 should return 15 (sum of 3, 5 and 7).

Examples : 

Input : arr[] = {5, 5, 10, 100, 10, 5}
Output : 110

Input : arr[] = {1, 2, 3}
Output : 4

Input : arr[] = {1, 20, 3}
Output : 20
*/
using System;

namespace MaximumSumNoAdjacent
{
    class MaximumSumNoAdjacent
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 5, 10, 100, 10, 5 };
            Console.WriteLine($"Max sum in array with no adjacent element is: {GetMaximumSumNoAdjacent(arr)}");

        }
        private static int GetMaximumSumNoAdjacent(int[] arr)
        {
            int arrLen = arr.Length;
            int evenSum = 0, oddSum = 0;
            if (arrLen == 1) return arr[0];
            for (int i = 0; i < arrLen; i+=2)
            {
                evenSum += arr[i];
            }
            for (int i = 1; i < arrLen; i += 2)
            {
                oddSum += arr[i];
            }
            return oddSum > evenSum  ? oddSum : evenSum;
        }
    }
}
