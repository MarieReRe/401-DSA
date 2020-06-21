using DataStructures.HashTables;
using Xunit;


namespace ChallengesTest
{
    public class RepeatedWordTests
    {
        [Fact]
        public void CanFindRepeatedWord()
        {
            string testString = "Once upon a time in a galaxy far, far away...";
            string result = RepeatedWord.RepeatedWords(testString);
            Assert.Equal("a", result);
        }
    }
}
