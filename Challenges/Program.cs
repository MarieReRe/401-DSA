using System;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = { 0, 1, 2, 3, 4, 5, 5, 19, 33 };
            Console.WriteLine(String.Join(", ", ReverseArray(initialArray)));
        }
           static int[] ReverseArray(int[] array)
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
