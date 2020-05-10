using DataStructures;
using System;
using System.Collections.Generic;
using Xunit;

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

    }
}