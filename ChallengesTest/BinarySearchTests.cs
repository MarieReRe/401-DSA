using Challenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengesTest
{
    public class BinarySearchTests
    {
       [Fact]
       public static void ThereIsAnIndex()
        {
            int[] array = { 1, 2, 3, 13, 122, 900};
            int searchKey = 3;
            int result = ArrayChallenges.BinarySearch(array, searchKey);
            Assert.Equal(2, result);
        }
        [Fact]
        public static void KeyNotFound()
        {
            int[] array = { 1, 2, 3, 13, 122, 900 };
            int searchKey = 77;
            int result = ArrayChallenges.BinarySearch(array, searchKey);
            Assert.Equal(-1, result);
        }
        // multi values

        // empty array

        // search key null

        // array not sorted










    }

  
}
