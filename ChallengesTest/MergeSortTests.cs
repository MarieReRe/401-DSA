using Challenges.MergeSorting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengesTest
{
   public class MergeSortTests
    {
        [Theory]
        [InlineData(new[] { 9, 1, 42, 27, 15 }, new[] { 1, 9, 15, 27, 42 })]
        [InlineData(new[] { 20, 18, 12, 8, 5, -2 }, new[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new[] { 5, 12, 7, 5, 5, 7 }, new[] { 5, 5, 5, 7, 7, 12 })]
        //Can sort an array of zeros
        [InlineData(new[] { 0, 0,0, 0, 0 }, new[] { 0, 0, 0, 0, 0 })]

        public void Can_Do_MargeSort(int[] input, int[] expected)
        {

            // act
            int[] result = MergeSort.MergeSortAlgo(input);


            //assert 
            Assert.Equal(expected, result);

        }
    }
}
