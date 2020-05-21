using System;
using System.Collections.Generic;
using System.Text;
using Challenges;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace ChallengesTest
{
    public class MultibracketTests
    {
        [Theory]
        [InlineData("<(!--{Hello!})>", true)]
        [InlineData("<>", true)]
        [InlineData("()})>", false)]
        [InlineData("!)", false)]
        [InlineData("(", false)]
        [InlineData("<(!-d-{(d)(d)()()()h}h)h>", true)]
        [InlineData("{}", true)]
        public void MatchedBracket(string input, bool expected)
        {
          
            bool actual = MultiBracket.IsMatched(input);

            Assert.Equal(expected, actual);




        }

       



    }
}
