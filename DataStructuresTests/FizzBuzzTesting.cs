using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{
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
            Tree<object> newTree = new Tree<object>(70);
            Assert.Equal(70, newTree.Root.Value);
        }

    }
}
