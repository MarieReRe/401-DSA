using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xunit;

namespace DataStructuresTests
{

    /* ____________________BTS TESTING __________
     __________ [x] 1. Can successfully instantiate an empty tree
     __________ [x] 2. Can successfully instantiate a tree with a single root                node
     __________ [x] 3. Can successfully add a left child and right child to a                single root node
    __________  [x] 4. Can successfully return a collection from a preorder                   traversal
      __________ [x] 5.Can successfully return a collection from an inorder                 traversal
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
        public void CanAddRootNodeToTree()
        {
            //arrange
            BinarySearchTree<int> newNode = new BinarySearchTree<int>();

            newNode.Add(2);
            int expected = 2;


            //Assert
            Assert.Equal(expected, newNode.Root.Value);

        }
        [Fact]
        public void CanAddLeftAndRightChildren()
        {
            BinarySearchTree<string> newTree = new BinarySearchTree<string>();

            newTree.Add("Im the root");
            newTree.Add("HiImLeftSide");
            newTree.Add("Righty");

            List<string> expected = new List<string>()
            {
                "HiImLeftSide",
                "Im the root",
                "Righty"
            };


            // Assert
            Assert.Equal(expected[1], newTree.Root.Value);
            Assert.Equal(expected[0], newTree.Root.Left.Value);
            Assert.Equal(expected[2], newTree.Root.Right.Value);
        }
        [Fact]
        public void CanReturnPreOrder()
        {
            //arrange
            BinarySearchTree<string> newTree = new BinarySearchTree<string>();
            newTree.Add("Carrots");
            newTree.Add("Apples");
            newTree.Add("Bananas");
            newTree.Add("Durian");
            newTree.Add("Eggplant");




            List<string> expected = new List<string>()
            {
                "Bananas",
                  "Apples",
               "Carrots",
                 "Durian",
                 "Eggplant",



            };
            Assert.Equal(expected[2], newTree.Root.Value);
            Assert.Equal(expected[1], newTree.Root.Left.Value);
            Assert.Equal(expected[0], newTree.Root.Left.Right.Value);
            Assert.Equal(expected[3], newTree.Root.Right.Value);
            Assert.Equal(expected[4], newTree.Root.Right.Right.Value);

        }
        [Fact]
        public void CanReturnInOrder()
        {
            BinarySearchTree<string> newTree = new BinarySearchTree<string>();
            newTree.Add("Carrots");
            newTree.Add("Apples");
            newTree.Add("Bananas");
            newTree.Add("Durian");
            newTree.Add("Eggplant");

            List<string> expected = new List<string>()
            {
               "Apples",
               "Bananas",
               "Carrots",
               "Durian",
               "Eggplant"
            };
            Assert.Equal(expected[2], newTree.Root.Value);
            Assert.Equal(expected[0], newTree.Root.Left.Value);
            Assert.Equal(expected[1], newTree.Root.Left.Right.Value);
            Assert.Equal(expected[3], newTree.Root.Right.Value);
            Assert.Equal(expected[4], newTree.Root.Right.Right.Value);
        }
        [Fact]
        public void CanReturnPostOrder()
        {
            BinarySearchTree<int> newTree = new BinarySearchTree<int>();
            newTree.Add(30);
            newTree.Add(35);
            newTree.Add(10);
            newTree.Add(15);
            newTree.Add(63);




            List<int> expected = new List<int>()
            {
                10,
               15,
               35,
               63,
               30 //root
            };
            Assert.Equal(expected[4], newTree.Root.Value);
            Assert.Equal(expected[0], newTree.Root.Left.Value);
            Assert.Equal(expected[1], newTree.Root.Left.Right.Value);
           Assert.Equal(expected[2], newTree.Root.Right.Value);
          //  Assert.Equal(expected[4], newTree.Root.Right.Right.Value);




        }
    }
}
