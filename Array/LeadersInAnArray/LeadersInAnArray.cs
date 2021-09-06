/* Write a program to print all the LEADERS in the array. An element is leader if it is greater than all the 
elements to its right side. And the rightmost element is always a leader.

For example int the array {16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2.
*/
using System;

namespace LeadersInAnArray
{
    class LeadersInAnArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            Console.Write("Leaders in the array:");
            PrintLeadersInAnArray(arr);
        }

        private static void PrintLeadersInAnArray(int[] arr)
        {
            int arrLen = arr.Length;
            int currMin = int.MinValue;
            for (int i = arrLen - 1; i >= 0; i--)
            {
                if (arr[i] > currMin)
                {
                    Console.Write($" {arr[i]}");
                    currMin = arr[i];
                }
            }
        }
    }
}
