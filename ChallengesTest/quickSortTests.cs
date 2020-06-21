using Challenges.QuickSort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengesTest
{
    public class quickSortTests
    {
        [Fact]
        public void CanSortArray()
        {
            int[] testArray = { 5, 7, 4, 9, 1, 3, 8, 2, 6 };
            QuickSort.Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.Equal(resultArray, QuickSort.Quicksort(testArray, 0, testArray.Length - 1));


        }
        [Fact]
        public void CanSortSameValues()
        {
            int[] testArray = { 7, 7, 7, 5, 7, 1, 7 };
            QuickSort.Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 1, 5, 7, 7, 7, 7, 7 };
            Assert.Equal(resultArray, QuickSort.Quicksort(testArray, 0, testArray.Length - 1));
        }
        [Fact]
        public void CanSortReverse()
        {
            int[] testArray = { 11, 9, 7, 5, 3, 1 };
            QuickSort.Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 1, 3, 5, 7, 9, 11 };
            Assert.Equal(resultArray, QuickSort.Quicksort(testArray, 0, testArray.Length - 1));
        }

        [Fact]
        public void CanSortAllZeros()
        {
            int[] testArray = { 0, 0, 0, 0, 0, 0, 0 };
            QuickSort.Quicksort(testArray, 0, testArray.Length - 1);
            int[] resultArray = { 0, 0, 0, 0, 0, 0, 0 };
            Assert.Equal(resultArray, QuickSort.Quicksort(testArray, 0, testArray.Length - 1));
        }

    }
}
