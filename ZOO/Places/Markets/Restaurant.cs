using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Restaurant : Markets
    {

        String foodToday;



        public Restaurant(int placeNum, string placeName,  float PlaceSizes ,decimal rentBills)
        {
            this.placeNum = placeNum;
            this.placeName = placeName;
            this.placeSize = PlaceSizes;
            this.rentBills = rentBills;
           this.placeType = "Restaurant";

        }




        public override void billsLinit()
        {
            if (monthlyBills < 350 && monthlyBills >= 200)
            {
                Console.WriteLine("Warning your bills is High");
            }
            else if (monthlyBills >= 350)
            {
                Console.WriteLine("fired, in 2 day close the hut");
            }


        }
        /// <summary>
        /// to add bills 
        /// </summary>

        public override void otherBills()
        {
            Console.WriteLine("write bill name");
            string billname = Console.ReadLine();

            if (billname == "rent")
            {
                monthlyBills += rentBills;
            }
            else
            {

                try
                {
                    Console.WriteLine("write bill value");
                    monthlyBills += Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("add new bill .");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// return the market type
        /// </summary>
        /// <returns> the market type</returns>
        public override string placeTypes()
        {

            string stringType = $"place Type small {placeType} ";
            return stringType;
        }


        /// <summary>
        /// print on console what is the food Today
        /// </summary>
        public void todayFood() {

             foodToday = "Meatball";
            Console.WriteLine($"today meal is {foodToday}");

        }
    }
}
