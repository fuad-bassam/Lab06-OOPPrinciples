using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Rabbit:Prey,IRareAnimal
    {

        string rabbitEyes;

        public Rabbit(String name, int age, String[] food, String sex, int sizePerUnit, string rabbitEyes)
        {

            this.name = name;
            this.age = age;
            this.animalWeather ="plains";
            this.food = food;
            this.Sex = sex;
            this.SizePerUnit = sizePerUnit;
            this.rabbitEyes = rabbitEyes;
            this.animalType = "Prey";

        }

        public String getEyes() {

            return rabbitEyes;
        }
        public int getCount()
        {
            return 10;
        }
    }
}
