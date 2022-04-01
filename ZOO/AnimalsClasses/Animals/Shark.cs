using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Shark:Predator,ISeaAnimal,IRareAnimal
    {

        public Shark(String name, int age,  String[] food, String sex, int sizePerUnit)
        {

            this.name = name;
            this.age = age;
           
            this.food = food;
            this.Sex = sex;
            this.SizePerUnit = sizePerUnit;
            this.animalWeather = "water";
            this.animalType = "Predator";

        }

        public String WaterDepth() {


            return "10 feet";


        }

        public int getCount()
        {
            return  5;
        }

        public string waterType()
        {
            return "Brine (salty water)";
        }
    }
}
