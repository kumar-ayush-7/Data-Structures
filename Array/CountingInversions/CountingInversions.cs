/* Inversion Count for an array indicates – how far(or close) the array is from being sorted.If array is already sorted then inversion count is 0. If array is sorted in reverse order that inversion count is the maximum.
Formally speaking, two elements a[i] and a[j] form an inversion if a[i] > a[j] and i < j

Example :
The sequence 2, 4, 1, 3, 5 has three inversions(2, 1), (4, 1), (4, 3).
*/
using System;

namespace CountingInversions
{
    class CountingInversions
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 1, 3, 5 };           
            Console.WriteLine(getCountingInversions(arr));
        }

        // 1. Simple method : For each element, count number of elements which are on right side of it and are smaller than it.


        private static int getCountingInversions(int[] arr)
        {
            int arrLen = arr.Length;
            int countInversions = 0;
            for (int i = 0; i < arrLen; i++)
            {
                for (int j = 0; j < arrLen; j++)
                {
                    if (arr[i] > arr[j] && i < j)
                    {
                        ++countInversions;
                    }
                }
            }
            return countInversions;
        }
    }
}
