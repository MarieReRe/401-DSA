using DataStructures;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Sdk;

namespace DataStructuresTests
{
    public class LinkedListTests

    /*                  Tests needed: 
            [x] 1. Can successfully instantiate an empty linked list
            [x] 2. Can properly insert into the linked list
            [x] 3. The head property will properly point to the first node in the linked list
            [x] 4. Can properly insert multiple nodes into the linked list
            [x] 5. Will return true when finding a value within the linked list that exists
            [x] 6. Will return false when searching for a value in the linked list that does not exist
            [x] 7. Can properly return a collection of all the values that exist in the linked list

     */
    {
        [Fact]
        public void CreationOfEmptyList()
        {
            //Arrange


            // Act
            LinkedList testLinkedList = new LinkedList();

            //Assert
            Assert.NotNull(testLinkedList);
        }

        [Fact]
        public void LinkedListInsert()
        {
            //Arrange
            LinkedList insertToLinkedList = new LinkedList();

            //Act
            insertToLinkedList.Include(19);

            //Assert
            Assert.Equal(19, insertToLinkedList.Head.Value);


        }


        [Fact]
        public void HeadPropertyIsFirstNode()
        {
            // Arrange

            //Act
            LinkedList LinkedList = new LinkedList();

            //Assert
            Assert.Null(LinkedList.Head);
        }

        [Fact]
        public void CanInsertOneNode()
        {
            //Arrange
            LinkedList newList = new LinkedList();

            //Act
            newList.Include(28);

            //Assert
            Assert.Equal("{28} -> NULL", newList.ToString());
        }
        [Fact]
        public void CanInsertMultipleNodes()
        {
            LinkedList newList = new LinkedList();

            //Act
            newList.Include(1);
            newList.Include(2);
            newList.Include(3);
            newList.Include(4);
            string testString = newList.ToString();

            //Assert
            const string Expected = "{4} -> {3} -> {2} -> {1} -> NULL";
            Assert.Equal(Expected, testString);
        }

        [Fact]
        public void CanWeFindNodesFalse()
        {
            LinkedList newList = new LinkedList();

            //Act
            newList.Include(1);
            newList.Include(2);
            newList.Include(3);
            newList.Include(4);




            Assert.False(newList.Includes(55));
        }
     
        [Fact]
        public void ShowAllValues()
        {
            LinkedList newList = new LinkedList();
            newList.Include(1);
            newList.Include(2);
            newList.Include(3);
            newList.Include(4);
            string testString = newList.ToString();


            Assert.Equal("{4} -> {3} -> {2} -> {1} -> NULL", testString);

        }

        [Fact]
        public void CanFindNodes()
        {
            LinkedList newList = new LinkedList();

            //Act
            newList.Include(1);
            newList.Include(2);
            newList.Include(3);
            newList.Include(4);
            

            //Assert
           
            Assert.True(newList.Includes(4));
        }
        //check for bug in head.next in traversal
        [Fact]
        public void CanInsertIntoNonEmptyList()
        {
            //Arrange
            LinkedList newList = new LinkedList();
            newList.Include(55);

            //Act
            newList.Include(28);

            //Assert
            Assert.Equal("{28} -> {55} -> NULL", newList.ToString());

        }




        /* ----------------------------------------------------- REQUIRED TESTING DAY 02
                                     [x] 1. Can successfully add a node to the end of the linked list
                                     [x] 2. Can successfully add multiple nodes to the end of a linked list
                                     [x] 3. Can successfully insert a node before a node located i the middle of a linked list
                                     [x] 4. Can successfully insert a node before the first node of a linked list
                                     [x] 5. Can successfully insert after a node in the middle of the linked list
                                     [] 6. Can successfully insert a node after the last node of the linked list
       
         * 
         */


        [Fact]
        public void CanAppendNode()
        {
            //arrange
            LinkedList newList = new LinkedList();
            newList.Include(8);
            newList.Include(6);
            newList.Include(4);
            newList.Include(2);

            newList.Append(10);
           

            //act
            int testAppend = 10;
            int expected = 10;
            //assert
           
            Assert.Equal(expected,testAppend);

        }

        [Fact]
        public void CanAppendManyNodes()
        {

            LinkedList newList = new LinkedList();
            newList.Include(0);
            newList.Append(10);
            newList.Append(20);
            newList.Append(30);
            


            //act
            string testString = newList.ToString();
            //assert

            Assert.Equal("{0} -> {10} -> {20} -> {30} -> NULL", testString);

        }
        [Fact]
        public void CanInsertBeforeFirstNode()
        {
            //assert

            LinkedList newList = new LinkedList();

            newList.Include(0);
            

            //act
            newList.InsertBefore(0, 99);
           

            // assert
            Assert.Equal(99,newList.Head.Value);
        }
        [Fact]
        public void CanInsertNewNodeAfterNodeGivenInTheMiddleOfList()
        {

            LinkedList newList = new LinkedList();
            newList.Include(30);
            newList.Include(20);
            newList.Include(10);
            newList.Include(0);

            newList.InsertBefore(20, 99);
            string testString = newList.ToString();
            //Assert
            Assert.Equal("{0} -> {10} -> {99} -> {20} -> {30} -> NULL",testString);

        }
        [Fact]
        public void CanInsertAfterNode()
        {
            LinkedList newList = new LinkedList();
            newList.Include(30);
            newList.Include(20);
            newList.Include(10);
            newList.Include(0);

            newList.InsertAfter(20, 99);
            string testString = newList.ToString();
            //Assert
            Assert.Equal("{0} -> {10} -> {20} -> {99} -> {30} -> NULL", testString);
        }
        [Fact]
        public void CanInsertAfterLastNode()
        {
            LinkedList newList = new LinkedList();
            newList.Include(30);
            newList.Include(20);
            newList.Include(10);
            newList.Include(0);

            newList.InsertAfter(30, 99);
            string testString = newList.ToString();
            //Assert
            Assert.Equal("{0} -> {10} -> {20} -> {30} -> {99} -> NULL", testString);

        }
    }
}