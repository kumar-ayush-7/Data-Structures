/*
There are two sorted arrays nums1 and nums2 of size m and n respectively.
Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0

Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5
*/
using System;
using System.Collections.Generic;

namespace MedianOfTwoSortedArray
{
    class MedianOfTwoSortedArray
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2,3 }, arr2 = { 4,5,6,27 };
            Console.WriteLine($"Median of two sorter array is: {GetMedian(arr1,arr2)}");
        }

        private static double GetMedian(int[] arr1, int[] arr2)
        {
            int arr1Len = arr1.Length, arr2Len = arr2.Length, finalLen = arr1Len + arr2Len;
            int i = 0, j = 0;
            List<int> list = new List<int>();
            while (i < arr1Len && j < arr2Len)
            {
                if(arr1[i] > arr2[j])
                {
                    list.Add(arr2[j]); j++;
                }
                else
                {
                    list.Add(arr1[i]); i++;
                }
                if(finalLen % 2 != 0 && list.Count > finalLen / 2)
                {
                    return list[list.Count - 1];
                }
                else if (finalLen % 2 == 0 && list.Count > finalLen / 2)
                {
                    return (list[list.Count - 1]+ list[list.Count - 2])/2;
                }
            }
            if(i < arr1Len)
            {
                while(i < arr1Len)
                {
                    list.Add(arr1[i]);
                    i++;
                }
            }
            else if(j < arr2Len)
            {
                while(j < arr2Len)
                {
                    list.Add(arr2[j]);
                    j++;
                }
            }
            if (finalLen % 2 != 0 && list.Count > finalLen / 2)
            {
                return list[list.Count - 1];
            }
            else
            {
                return ((Convert.ToDouble(list[list.Count/2]) + Convert.ToDouble(list[list.Count/2 - 1])) / 2);
            }

        }

    }
}
