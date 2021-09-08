/* Given an array of integers where each element represents the max number of steps that can be made forward from that element.
Write a function to return the minimum number of jumps to reach the end of the array (starting from the first element).
If an element is 0, they cannot move through that element.

Examples:

Input: arr[] = {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9}
Output: 3 (1-> 3 -> 8 -> 9)
Jump from 1st element to 2nd element as there is only 1 step, now there are three options 5, 8 or 9.
If 8 or 9 is chosen then the end node 9 can be reached. So 3 jumps are made.

Input:  arr[] = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
Output: 10
In every step a jump is needed so the count of jumps is 10.
*/
using System;

namespace MinJumpToReachEnd
{
    class MinJumpToReachEnd
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
            Console.WriteLine($"Required no of jumps: {GetMinJumpToEnd(arr, 0, arr.Length)}");
        }

        private static int GetMinJumpToEnd(int[] arr, int l, int h)
        {
            if (h == l)
                return 0;

            if (arr[l] == 0)
                return int.MaxValue;

            int min = int.MaxValue;
            for (int i = l + 1; i <= h && i <= l + arr[l]; i++)
            {
                int jumps = GetMinJumpToEnd(arr, i, h);
                if (jumps != int.MaxValue && jumps + 1 < min)
                    min = jumps + 1;
            }
            return min;
        }
    }
}
