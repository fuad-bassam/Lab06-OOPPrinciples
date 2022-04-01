using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Sheep:Prey
    {
        decimal WoolLenght;

        public Sheep(String name, int age,  String[] food, String sex, int sizePerUnit ,decimal WoolLenght)
        {

            this.name = name;
            this.age = age;
            this.animalWeather = "plains";
            this.food = food;
            this.Sex = sex;
            this.SizePerUnit = sizePerUnit;
            this.WoolLenght = WoolLenght;
            this.animalType = "Prey";

        }

        public void woolOk() {


            if (WoolLenght >= 4m)
            {
                Console.WriteLine("wool Ok");
            }
            else
            {
                Console.WriteLine("wool Not Ok");
            }

        
        }
    }
}
