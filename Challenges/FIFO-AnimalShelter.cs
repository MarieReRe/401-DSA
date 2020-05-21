using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructures;



namespace Challenges
{
    public abstract class Animal { }
    public class Dog : Animal { }
    public class Cat : Animal { }
    public class FifoAnimalShelter
    {
        private Node Front;
        private Node Rear;
       private class Node
        {

            public Animal Value { get; set; }
            public Node Next { get; set; }
            public Animal Front { get; set; }
            public Animal Rear { get; set; }

            //Constructor
            public Node(Animal animal)
            {
                Value = animal;
                Next = null;
            }
        }
        public void ArriveAtShelter(Animal animal)
        {
            Node newNode = new Node(animal);
            //put in Queue - Enqueue
            if (Front is null)
            {
                Front = newNode;
                Rear = newNode;
            }

            Rear.Next = newNode;
            Rear = newNode;

        }

        //set up take home an animal
       public  Animal TakeHome()
        {
            return null; //fix to make a test pass
        }
        //if someone calls takehome and specifies dog/cat/other return that type
       public  TAnimal TakeHome<TAnimal>()
            where TAnimal : Animal
       {
            Node current = Front;
            while (current != null)
            {
                //if current node.value is TAnimal if its a cat then....use "is" <- type check
                if (current.Value is TAnimal animal )
                {
                    current = current.Next;

                    if (current == null) Rear = null; return animal;

                }

                current = current.Next;
             



            }
         
           return null ;//test 
       }




    }
}
