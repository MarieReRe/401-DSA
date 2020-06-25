using Challenges.DepthFirst;
using DataStructures.GraphImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ChallengesTest
{
   public class DFTTesting
    {
        [Fact]
        public void DepthFirstOnEmptyGraphReturnsNull()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Null(DFS.DepthFirst(graph, 1));
        }


    }
}
