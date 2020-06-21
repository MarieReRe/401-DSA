using DataStructures.GraphImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{
   public class GraphTesting
    {

        /* -------------------------------------------- GRAPH TESTING--------------------------------------------------------------
                            [x] 1. Node can be successfully added to the graph
                            [] 2. An edge can be successfully added to the graph
                            [] 3. A collection of all nodes can be properly retrieved from the graph
                            [] 4. All appropriate neighbors can be retrieved from the graph
                            [] 5. Neighbors are returned with the weight between nodes included
                            [] 6. The proper size is returned, representing the number of nodes in the graph
                            [] 7. A graph with only one node and edge can be properly returned
                            [x] 8. An empty graph properly returns null
         
      -----------------------------------------------------------------------------------------------------------------------   */
        [Fact]
        public void EmptyGraphReturnsNull()
        {
            //arrange
            Graph<int> newGraph = new Graph<int>();
            //Act
            //Assert
            Assert.Null(newGraph.GetNodes());
        }
        [Fact]
        public void CanAddNodeToGraph()
        {
            //Arrange
            Graph<int> newGraph = new Graph<int>();
            newGraph.AddNode(3);

            //Assert
            Assert.Contains(3, newGraph.GetNodes());
        }
        [Fact]
        public void EdgeCanBeAdded()
        {
            Graph<int> newGraph = new Graph<int>();
            newGraph.AddNode(3);
            newGraph.AddNode(6);
            newGraph.AddNode(9);
            newGraph.AddEdge(3,6);

            Assert.True(newGraph);

        }
    }
}
