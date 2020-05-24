using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructuresTests
{

    /* ____________________BTS TESTING __________
     __________ [] 1. Can successfully instantiate an empty tree
     __________ [] 2. Can successfully instantiate a tree with a single root                node
     __________ [] 3. Can successfully add a left child and right child to a                single root node
    __________  [] 4. Can successfully return a collection from a preorder                   traversal
      __________ [] 5.Can successfully return a collection from an inorder                 traversal
      __________ [] 6. Can successfully return a collection from a postorder               traversal _____________________________________________*/
    public class BinarySearchTreeTesting
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
          
            //assert
            Assert.Null(binaryTree.Root);
           

        }
        [Fact]
        public void CanAddOneNodeToTree()
        {
            //arrange
            BinarySearchTree<int> newNode = new BinarySearchTree<int>();

            newNode.Add(2);
            int expected = 2;


            //Assert
            Assert.Equal(expected, newNode.Root.Value);



           

        }
    }
}
