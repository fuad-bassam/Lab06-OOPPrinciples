using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{



    public class Cages : Places
    {

        int space;

        string weather;

        List<Animals> animals = new List<Animals>(10);

        String[] foodType = null;




       public Cages(int placeNum, string placeName,  float PlaceSizes, int space, string weather ,string[] foodType) 
        {
            this.placeNum = placeNum;
            this.placeName = placeName;
            this.placeSize = PlaceSizes;
            this.space = space;
            this.weather = weather;
            this.placeType = "cage";
            this.foodType = foodType;
        }


        /// <summary>
        /// it is example need more wore but the main idea it the place type
        /// </summary>
        /// <returns></returns>
        public override string placeTypes()
        {
                       
            string stringType = $"place Type {placeType}";
            return stringType;
        }


        /// <summary>
        /// we deal with animal size as units (like big animal =3 unit, Small animal = 1 unit ) 
        /// in this method we test if animal can fit in the cage
        /// </summary>
        /// <param name="animal">any animal we want to test (polymorphism)</param>
        /// <returns></returns>
        public bool SpacePerUnit(Animals animal) {

            
            if (animal.getAnimalSize() <= space)
            {
                space -= animal.getAnimalSize();
                return true;
            }

            return false;
        
        }


        /// <summary>
        /// return all the animal in the cage
        /// </summary>
        /// <returns></returns>

        public String getAnimals()
        {
            String animalsString="";


                foreach (Animals animal in animals)
            {

                animalsString = animalsString + $"{animal.getName()} \n";
            }

            return animalsString;


        }



        /// <summary>
        /// just return the weather in the cage (ice ,water ,desert ,Jungle,plains ....etc)
        /// </summary>
        /// <returns></returns>
        public String pleceWeather()
        {

            return weather;


        }


        /// <summary>
        /// check if new animal can live with in weather in cage  
        /// </summary>
        /// <param name="animal">any animal we want to test (polymorphism)</param>
        /// <returns></returns>
        public bool isOkWeather(Animals animal)
        {

            if (animal.getAnimalWeather() == weather)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// / check if the animals  in cage can live with new animal
        /// </summary>
        /// <param name="animal">any animal we want to test (polymorphism)</param>
        /// <returns></returns>
        public bool isOkAnimal(Animals animal)
        {
            return true;
        }

        /// <summary>
        /// return foods as string
        /// </summary>
        /// <returns></returns>

        public String  food()
        {
            string foodList ="";

            foreach (string food in foodType)
            {
                foodList =foodList + $"[ {food} ] ";
            }

            return foodList;
        }


        /// <summary>
        /// check if can add new animal in the cage
        /// </summary>
        /// <param name="animal"></param>


        public void addAnimal(Animals animal)
        {

            if (isOkAnimal(animal) && isOkWeather(animal))
            {
                if (SpacePerUnit(animal))
                {
                    animals.Add(animal);
                    Console.WriteLine("added animal");
                }
                else
                {
                    Console.WriteLine("cage space can NOT handle animal size");
                }
              
            }
            else
            {
                Console.WriteLine("cant add this animal check the weather or the animals in this cage");
            }

           
        }

    }
}
