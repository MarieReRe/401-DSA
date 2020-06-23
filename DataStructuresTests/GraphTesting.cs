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
                            [x] 2. An edge can be successfully added to the graph
                            [x] 3. A collection of all nodes can be properly retrieved from the graph
                            [x] 4. All appropriate neighbors can be retrieved from the graph
                            [x] 5. Neighbors are returned with the weight between nodes included
                            [x] 6. The proper size is returned, representing the number of nodes in the graph
                            [x] 7. A graph with only one node and edge can be properly returned
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

            Assert.True(newGraph.GetNeighbors(3).ContainsKey(6) );

        }
        [Fact]
        public void CanGetAllNodes()
        {
            List<int> expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Graph<int> graph = new Graph<int>();
            foreach (int i in expected)
            {
                graph.AddNode(i);
            }
            Assert.Equal(expected, graph.GetNodes());
        }
        [Fact]
        public void CanGetNeighbors()
        {
            Graph<int> newGraph = new Graph<int>();
            for (int i = 1; i < 6; i++)
            {
                newGraph.AddNode(i);
            }
            for (int i = 2; i < 6; i++)
            {
                newGraph.AddEdge(1, i);
            }
            Assert.Equal(4, newGraph.GetNeighbors(1).Count);
        }
        [Fact]
        public void CanGetEdgeWeights()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(1);
            graph.AddNode(10);
            graph.AddEdge(1, 10, 100);
            Assert.Equal(100, graph.GetNeighbors(1).GetValueOrDefault(10));
        }
        [Fact]
        public void CanGetSize()
        {
            Graph<int> newGraph = new Graph<int>();
            newGraph.AddNode(5);
            newGraph.AddNode(10);
            newGraph.AddNode(15);
            newGraph.AddNode(20);
            newGraph.AddNode(25);

            Assert.Equal(5, newGraph.Size());
        }
        [Fact]
        public void CanAddEdgeWithSameNodeInGraphOfOneNode()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(1);
            graph.AddEdge(1, 1);
            Assert.Single(graph.GetNeighbors(1));
        }

        /*_________________________________________________BREADTH FIRST TRAVERSAL TESTING ________________________________________ ______________________________________________________________________________________________________________________________*/

        [Fact]
        public void BreadthFirstOnEmptyGraphReturnsNull()
        {
            Graph<int> graph = new Graph<int>();
            Assert.Null(graph.BreadthFirstTraversal(5));
        }
        [Fact]
        public void CanPerformBreadthFirst()
        {
            Graph<int> graph = new Graph<int>();
            for (int i = 1; i < 8; i++)
            {
                graph.AddNode(i);
            }

            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(1, 5);
            graph.AddEdge(2, 5);
            graph.AddEdge(5, 6);
            graph.AddEdge(4, 7);
            graph.AddEdge(5, 7);

            List<int> expected = new List<int> { 1, 2, 4, 5, 3, 7, 6 };
            Assert.Equal(expected, graph.BreadthFirstTraversal(1));
        }
        [Fact]
        public void BreadthFirstIgnoresIslands()
        {
            Graph<int> graph = new Graph<int>();
            for (int i = 1; i < 8; i++)
            {
                graph.AddNode(i);
            }

            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(1, 5);
            graph.AddEdge(2, 5);
            graph.AddEdge(5, 6);
            graph.AddEdge(5, 7);

            List<int> expected = new List<int> { 1, 2, 5, 3, 6, 7 };
            Assert.Equal(expected, graph.BreadthFirstTraversal(1));
        }
    }
}
