/* Write a function leftRotate(arr[], n, k) that rotates arr[] of size n by k elements to the left.

Example:
Array : 1,2,3,4,5,6,7
Rotation of above array by 2 will make array
3,4,5,6,7,1,2

*/
using System;

namespace RotateArray
{
    class RotateArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int rotationCount = 8, arrLen = arr.Length;
            rotationCount = rotationCount > arrLen ? rotationCount - arrLen : rotationCount;
            Console.WriteLine($"Array before rotation : {string.Join(", ", arr)}");
            LeftRotate(ref arr,arr.Length, rotationCount);
            Console.WriteLine($"Array post rotation by {rotationCount} : {string.Join(", ", arr)}");
        }

        private static void LeftRotate(ref int[] arr, int length, int rotationCount)
        {
            int[] arrTemp = new int[length];
            for (int i = 0; i < length; i++)
            {
                if(i< rotationCount)
                {
                    arrTemp[length + i - rotationCount] = arr[i];
                }
                else
                {
                    arrTemp[i - rotationCount] = arr[i];
                }
            }
            arr = arrTemp;
        }
    }
}
