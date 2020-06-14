using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.MergeSorting
{
    public class MergeSort
    {


        public static int[] MergeSortAlgo(int[] array)
        {

            int[] leftHalf;
            int[] rightHalf;
            int[] result = new int[array.Length];

            if (array.Length <= 1)
                return array;

            int midpoint = array.Length / 2;
            leftHalf = new int[midpoint];


            if (array.Length % 2 == 0)
                rightHalf = new int[midpoint];

            else
                rightHalf = new int[midpoint + 1];

            for (int i = 0; i < midpoint; i++)
                leftHalf[i] = array[i];

            int x = 0;

            for (int i = midpoint; i < array.Length; i++)
            {
                rightHalf[x] = array[i];
                x++;
            }

            leftHalf = MergeSortAlgo(leftHalf);

            rightHalf = MergeSortAlgo(rightHalf);

            result = Merge(leftHalf, rightHalf);
            return result;
        }



        //Merging of the sorted items
        public static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int resultLength = rightArray.Length + leftArray.Length;
            int[] result = new int[resultLength];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftArray.Length || j < rightArray.Length)
            {

                if (i < leftArray.Length && j < rightArray.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (leftArray[i] <= rightArray[j])
                    {
                        result[k] = leftArray[i];
                        i++;
                        k++;
                    }

                    else
                    {
                        result[k] = rightArray[j];
                        j++;
                        k++;
                    }
                }

                else if (i < leftArray.Length)
                {
                    result[k] = leftArray[i];
                    i++;
                    k++;
                }

                else if (j < rightArray.Length)
                {
                    result[k] = rightArray[j];
                    j++;
                    k++;
                }
            }
            return result;
        }
    }
}

