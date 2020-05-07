using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        public static int BinarySearch(int[] array, int searchKey)
        {
            int midpoint = 0;
            int arrayStart = 0;
            int arrayEnd = array.Length - 1;
            

            // while loop check if start and end are same
            while( arrayStart <= arrayEnd)
            {
                midpoint = (arrayStart + arrayEnd) / 2;
                {
                    if(array[midpoint] < searchKey)
                    {
                        arrayStart = midpoint + 1;
                        Console.WriteLine($"{arrayStart}, {midpoint}, {arrayEnd}");
                    }
                    else if (array[midpoint] > searchKey)
                    {

                        arrayEnd = midpoint - 1;
                        Console.WriteLine($"{arrayStart}, {midpoint}, {arrayEnd}");
                    }
                    else
                    {
                        //if midppoint matches key
                        return midpoint;
                    }
                }
            }
            //check if key wasnt found on last loop
            if(array[midpoint] == searchKey)
            {
                return midpoint;
            }
            // return -1 if not foung
            return -1;
        }

    }
}
