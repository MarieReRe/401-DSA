using Challenges;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengesTest
{
    
    public class ArrayShiftTests
    {
        [Theory]
        [InlineData(new[] { 0, 1, 2, 3 }, new[] { 0, 1, 5, 2, 3})]
        public void can_shift_arrays(int[] input, int[] expected)
        {
            //Arrange: FROM INPUT
            int insertedNumber = 5;
            //Act
            int[] result = ArrayChallenges.ArrayShift(input, insertedNumber);

            //Assert
            Assert.Equal(expected, result);

        }

    }
}
