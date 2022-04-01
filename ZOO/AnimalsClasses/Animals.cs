using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Animals
    {
        protected string name;
        protected int age;
        protected String animalType;
        protected String animalWeather;
        protected string[] food;
        protected abstract string Sex { get; set; }
     
        protected List<String> healthDetails =new List<String>(12);
        protected abstract int SizePerUnit { get; set; }



        public void addHealthDetails() {

            Console.WriteLine("inter the case");

            string caseDetails = Console.ReadLine();

            healthDetails.Add(caseDetails);

            Console.WriteLine("case Add");


        }


        public String getInformation() {


            String info = $"animal name = {name} \n animal age = {age} \n animal type = {animalType} \n animal weather = {animalWeather} \n animal food = {food} \n animal sex = {Sex} \n animal size = {SizePerUnit}";

            return info;
        }


        public abstract void eat();



        public void animalSex() {


            Console.WriteLine($"the animal is {Sex}");
        
        
        }

        public String getType() {

            return animalType;
        
        }

      
        public String getAnimalWeather()
        {

            return animalWeather;

        }
        
       public int getAnimalSize()
        {

            return SizePerUnit;

        }
        public String getName()
        {

            return name;

        }
    }
}
