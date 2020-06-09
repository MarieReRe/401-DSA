using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Sorting
{
    public class InsertionSorting
    {
        
          public static int[] InsertionSort(int [] arr)
          {
             // Traverse through length of array, starting with the element at index 0.
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                
                 // Iterate through sorted items.
                 // If the current unsorted item is smaller than the item to its left,
                 // move the current item back one position in the array.
                 // This loop will never run for the very first unsorted item at index 0.

              for (j >= 0 && temp < arr [j] )
              {
                   
                    arr[j + 1] = arr[j];

                    
                //This while loop shifts items to the right in the sorted subset of the array
                    j = j - 1;
                    arr[j + 1] = temp;
    
              }
                   

                }
            return arr;
              
          }
        
    }
}
