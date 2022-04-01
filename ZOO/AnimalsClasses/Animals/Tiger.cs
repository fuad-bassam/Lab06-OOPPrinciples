using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Tiger:Predator
    {


        public Tiger(String name , int age ,String [] food,String sex ,int sizePerUnit) {

            this.name = name;
            this.age = age;
            this.animalWeather = "Jungle";
            this.food = food;
            this.Sex = sex;
            this.SizePerUnit = sizePerUnit;

            this.animalType = "Predator";

        }


        public void sound() {


            Console.WriteLine("Tiger voice is (growl)");
        }
    }
}
