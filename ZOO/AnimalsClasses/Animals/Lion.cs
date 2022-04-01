using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Lion : Predator
    {
        public Lion(String name, int age,  String[] food, String sex, int sizePerUnit)
        {

            this.name = name;
            this.age = age;
            this.animalWeather = "Jungle";
            this.food = food;
            this.Sex = sex;
            this.SizePerUnit = sizePerUnit;

            this.animalType = "Predator";

        }


        public void getNameAndType() {


            Console.WriteLine($"Lion name {name} and type is {getType()}" );
        
        }


    }
}
