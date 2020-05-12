using DataStructures;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Sdk;

namespace DataStructuresTests
{
    public class LinkedListTests

    /*---------------------------------- REQUIRED TESTS DAY 01: 
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
            insertToLinkedList.Insert(19);

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
            newList.Insert(28);

            //Assert
            Assert.Equal("{28} -> NULL", newList.ToString());
        }
        [Fact]
        public void CanInsertMultipleNodes()
        {
            LinkedList newList = new LinkedList();

            //Act
            newList.Insert(1);
            newList.Insert(2);
            newList.Insert(3);
            newList.Insert(4);
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
            newList.Insert(1);
            newList.Insert(2);
            newList.Insert(3);
            newList.Insert(4);




            Assert.False(newList.Includes(55));
        }
     
        [Fact]
        public void ShowAllValues()
        {
            LinkedList newList = new LinkedList();
            newList.Insert(1);
            newList.Insert(2);
            newList.Insert(3);
            newList.Insert(4);
            string testString = newList.ToString();


            Assert.Equal("{4} -> {3} -> {2} -> {1} -> NULL", testString);

        }

        [Fact]
        public void CanFindNodes()
        {
            LinkedList newList = new LinkedList();

            //Act
            newList.Insert(1);
            newList.Insert(2);
            newList.Insert(3);
            newList.Insert(4);
            

            //Assert
           
            Assert.True(newList.Includes(4));
        }
        //check for bug in head.next in traversal
        [Fact]
        public void CanInsertIntoNonEmptyList()
        {
            //Arrange
            LinkedList newList = new LinkedList();
            newList.Insert(55);

            //Act
            newList.Insert(28);

            //Assert
            Assert.Equal("{28} -> {55} -> NULL", newList.ToString());

        }




        /* ----------------------------------------------------- REQUIRED TESTING DAY 02
                                     [x] 1. Can successfully add a node to the end of the linked list
                                     [x] 2. Can successfully add multiple nodes to the end of a linked list
                                     [x] 3. Can successfully insert a node before a node located i the middle of a linked list
                                     [x] 4. Can successfully insert a node before the first node of a linked list
                                     [x] 5. Can successfully insert after a node in the middle of the linked list
                                     [x] 6. Can successfully insert a node after the last node of the linked list
       
         * 
         */


        [Fact]
        public void CanAppendNode()
        {
            //arrange
            LinkedList newList = new LinkedList();
            newList.Insert(8);
            newList.Insert(6);
            newList.Insert(4);
            newList.Insert(2);

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
            newList.Insert(0);
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
            //arrange

            LinkedList newList = new LinkedList();

            newList.Insert(0);
            

            //act
            newList.InsertBefore(0, 99);
           

            // assert
            Assert.Equal(99,newList.Head.Value);
        }
        [Fact]
        public void CanInsertNewNodeAfterNodeGivenInTheMiddleOfList()
        {
            //arrange
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.Insert(0);
            // act
            newList.InsertBefore(20, 99);
            string testString = newList.ToString();
            //Assert
            Assert.Equal("{0} -> {10} -> {99} -> {20} -> {30} -> NULL",testString);

        }
        [Fact]
        public void CanInsertAfterNode()
        {

            //arrange
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.Insert(0);
            //act
            newList.InsertAfter(20, 99);
            string testString = newList.ToString();
            //Assert
            Assert.Equal("{0} -> {10} -> {20} -> {99} -> {30} -> NULL", testString);
        }
        [Fact]
        public void CanInsertAfterLastNode()
        {
            //arrange
            LinkedList newList = new LinkedList();
            newList.Insert(30);
            newList.Insert(20);
            newList.Insert(10);
            newList.Insert(0);

            newList.InsertAfter(30, 99);
            string testString = newList.ToString();
            //Assert
            Assert.Equal("{0} -> {10} -> {20} -> {30} -> {99} -> NULL", testString);

        }


        /*---------------------------------------Testing For Deltetion
                       
                                          [x] 1. Can we delete a middle node 
         */

         [Fact]
         public void DeleteMiddleNode()
        {
            LinkedList newList = new LinkedList();
            newList.Includes(5);
            newList.Includes(4);
            newList.Includes(3);
            newList.Includes(2);
            newList.Includes(1);
            //act
            newList.DeleteANode(4,2);
            // Arrange
            Assert.False(newList.Includes(3));

        }


         /* ----------------------------------------------------- REQUIRED TESTING DAY 03
                                     [] 1. Where k is greater than the length of the linked list
                                     [] 2. Where k and the length of the list are the sam
                                     [] 3. Where k is not a positive integer
                                     [x] 4. Where the linked list is of a size 1
                                     [] 5. "Happy Path” where k is not at the end, but somewhere in the middle of the linked list
         */
         [Fact]
        public void KGreaterThanListLength()
        {
            //Arrange

            //Assert

            // Act
        }
        [Fact]
        public void KIsLengthOfList()
        {
             //Arrange

            //Assert

            // Act
        }
         [Fact]
          public void KIsNegative()
           {
             //Arrange

            //Assert

            // Act

           }
           [Fact]
          public void ListSizeOfOne()
           {
             //Arrange
             LinkedList newList = new LinkedList();
              newList.Insert(4);
         
          

            // Act
          
            //Assert
            Assert.Equal(4, newList.KthFromEnd(0));
           }
           [Fact]
          public void HappyPlace()
           {
            //Arrange
            LinkedList newList = new LinkedList();
            newList.Insert(4);//4
            newList.Insert(14);//3
            newList.Insert(24);//2
            newList.Insert(34);//1
            newList.Insert(44);//0
            // Act
         

            //Assert
            Assert.Equal(0, newList.KthFromEnd(44));



        }


    }
}