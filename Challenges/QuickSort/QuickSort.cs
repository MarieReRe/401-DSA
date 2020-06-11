using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.QuickSort
{
    public class QuickSort
    {

        public static int[] Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                Quicksort(arr, left, position - 1);
                Quicksort(arr, position + 1, right);
            }
            return arr;
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }
         static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }


    }
}
