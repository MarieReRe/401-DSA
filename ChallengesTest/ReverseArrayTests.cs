using Challenges;
using Xunit;

namespace ChallengesTest
{
    public class ReverseArrayTests
    {
        [Theory]
        [InlineData(new[] {0, 1, 2, 3 }, new[] { 3, 2, 1, 0 })]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        public void ReverseAnArrayOfNumbers(int[] input, int[] expected)
        {

            //Arrange

            //Act 
            int[] result = ArrayChallenges.ReverseArray(input);

            // Assert
            Assert.Equal(expected, result);

            // Not in-place reversal
            Assert.NotSame(input, result);
        }

    }

}
