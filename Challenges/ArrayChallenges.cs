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

    }
}
