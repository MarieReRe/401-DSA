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
                    [] 3. Create tree with string
                    [] 4. Return tree with strings and ints
                    [] 5. Add Left and Right Children
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
            Tree<object> newTree = new Tree<object>("Marie");
            Assert.Equal("Marie", newTree.Root.Value);
        }

    }
}
