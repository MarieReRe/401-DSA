using System;
using System.Collections.Generic;
using System.Text;
using Challenges;
using Xunit;

namespace ChallengesTest
{
    public class FifoAnimalShelterTests
    {
        [Fact]
        public void EnqueueCat()
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            FifoAnimalShelter shelter = new FifoAnimalShelter();

            shelter.ArriveAtShelter(dog);
            shelter.ArriveAtShelter(cat);

            //act: generic constraint specifies a type that matches the criteria. 
           Cat result = shelter.TakeHome<Cat>();


            //Assert
            Assert.Equal(cat, result);
        }
    }
}
