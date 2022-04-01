using System;

namespace ZOO
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello zoo!");

            string[] foodArray1 = { "meat", "fish" };
            string[] foodArray2 = { "grass", "vegetables" };

            Cages Cage1 = new Cages(1, "Cage1", 12f, 14, "Jungle",foodArray1);
            Cages Cage2 = new Cages(2, "Cage2", 10f, 12, "water",foodArray1);
            Cages Cage3 = new Cages(3, "Cage3", 20f, 18, "plains",foodArray2);

            Lion lion1 = new Lion("sime", 4, foodArray1, "male", 3);
            Tiger tiger1 = new Tiger("olalo", 2,  foodArray1, "female", 3);
            Shark shark1 = new Shark("aliki", 6, foodArray1, "male", 3);
            Sheep sheep1 = new Sheep("mosaa", 6, foodArray1, "male", 3,4m);
            Rabbit rabbit3 = new Rabbit("pany", 6, foodArray1, "male", 3,"red");


          
            Cage1.addAnimal(lion1);
            Cage1.addAnimal(tiger1);
            Cage3.addAnimal(rabbit3);
            Cage3.addAnimal(sheep1);
            Cage2.addAnimal(shark1);

            Console.WriteLine(Cage1.food());
            Console.WriteLine(Cage1.getAnimals());
            Console.WriteLine( Cage1.getSize());
            Console.WriteLine(Cage1.placeTypes());

            Console.WriteLine(lion1.getType());
            lion1.getNameAndType();
            Console.WriteLine(lion1.getInformation());

            sheep1.woolOk();      

             Console.WriteLine( rabbit3.getCount());
            Console.WriteLine(rabbit3.getEyes());

            tiger1.sound();

            shark1.waterType();
            Console.WriteLine(shark1.WaterDepth());
            Console.WriteLine(shark1.getCount());
        }
    }
}
