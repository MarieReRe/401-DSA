using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Sorting
{
    public class InsertionSorting
    {
          public static int[] InsertionSort(int [] arr)
          {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

               while (j >= 0 && temp < arr [j] )
                {
                   
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    arr[j + 1] = temp;
    
                }
                   

                }
            return arr;
              
          }
        
    }
}
