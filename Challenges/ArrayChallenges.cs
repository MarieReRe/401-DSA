using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class ArrayChallenges
    {

        public static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray.SetValue(array[array.Length - 1 - i], i);
            }
            return reversedArray;
        }
        public static int[] ArrayShift(int[] array, int insertedNumber)
        {
            // what is the array length
            int[] shiftedArray = new int[array.Length + 1];
            int midpoint = array.Length / 2;
           

            // need a for loop to insert elements from given array to new array
            for(int i = 0; i < shiftedArray.Length; i++)
            {
                if( i < midpoint)
                {
                    shiftedArray[i] = array[i];
                }
                else if(i == midpoint)
                {
                    shiftedArray[i] = insertedNumber;
                }
                else
                {
                    shiftedArray[i] = array[i - 1];
                }
            }
            for(int i = 0; i < shiftedArray.Length; i++)
            {
                Console.WriteLine(shiftedArray[i] + " ");
            }
           


            //We need to return the shifted array
            return shiftedArray;

        }

    }
}
