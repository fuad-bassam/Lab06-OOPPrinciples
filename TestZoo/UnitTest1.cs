using System;
using Xunit;
using ZOO;

namespace TestZoo
{
    public class UnitTest1
    {

        
        public static string[] foodArray1 = { "meat", "fish" };
        string[] foodArray2 = { "grass", "vegetables" };

        //Lab 6 tests
        [Fact]
        public void TestConcreteInherit1()
        {

            Lion lion1 = new Lion("sime", 4, foodArray1, "male", 3);

            Assert.Equal("Jungle", lion1.getAnimalWeather());
        }

        [Fact]

        public void TestConcreteInherit2()
        {

            Shark shark2 = new Shark("frash", 7, foodArray1, "female", 5);

            Assert.Equal(5, shark2.getAnimalSize());
        }

        [Fact]
        public void TestInterfaceImplemnt1()
        {

            Rabbit rabbit2 = new Rabbit("rose", 1, foodArray2, "female", 1,"red");

            Assert.Equal("red", rabbit2.getEyes());
        }

        [Fact]
        public void TestInterfaceImplemnt2()
        {

            Shark shark2 = new Shark("rose", 1, foodArray2, "female", 1);

            Assert.Equal("Brine (salty water)", shark2.waterType());
        }



        [Fact]
        public void TestInheritance()
        {
            Rabbit rabbit2 = new Rabbit("rose", 1, foodArray2, "female", 1, "red");

            Assert.Equal(1, rabbit2.getAnimalSize());
        }

        [Fact]
        public void TestPolyIsAAnimal()
        {
            Animals rabbit2 = new Rabbit("rose", 1, foodArray2, "female", 1, "red");

            Assert.Equal(1, rabbit2.getAnimalSize());
        }

        [Fact]
        public void TestOverride()
        {
            Rabbit rabbit2 = new Rabbit("rose", 1, foodArray2, "female", 1, "red");

            Lion lion1 = new Lion("sime", 4, foodArray1, "male", 3);

            Assert.True(!lion1.isokWith(rabbit2));
        }

        [Fact]
        public void TestOverride2()
        {
            Lion lion1 = new Lion("sime", 4, foodArray1, "male", 3);

            Lion lion2 = new Lion("alok", 2, foodArray1, "female", 3);

            Assert.True(lion1.isokWith(lion2));
        }


    }
}

