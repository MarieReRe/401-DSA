using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{

    /*-------------------------------------------------FIZZBUZZ TESTING: 
                    [] 1. Instantiate empty tree 
                    [] 2. Create tree starting with an int
-------------------------------------------------------------------------------------------------------------------------------------*/
    public class FizzBuzzTesting
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            Tree<object> newTree = new Tree<object>();
            Assert.Null(newTree.Root);
        }
        [Fact]
        public void CreateTreeWithIntAsRoot()
        {
            Tree<object> newTree = new Tree<object>(1);
            Assert.Equal(1, newTree.Root.Value);
        }
        [Fact]
        public void CanInstantiateTreeWithString()
        {
            Tree<object> tree = new Tree<object>("Marie");
            Assert.Equal("Marie", tree.Root.Value);
        }

    }
}
