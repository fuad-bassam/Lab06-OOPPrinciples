using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class ParkGames : Markets
    {


        public ParkGames(int placeNum, string placeName, float PlaceSizes, decimal rentBills)
        {
            this.placeNum = placeNum;
            this.placeName = placeName;
            this.placeSize = PlaceSizes;
            this.rentBills = rentBills;
            this.placeType = "ParkGames";

        }

        public override void billsLinit()
        {
            if (monthlyBills < 200 && monthlyBills >= 100)
            {
                Console.WriteLine("Warning your bills is High");
            }
            else if (monthlyBills >= 200)
            {
                Console.WriteLine("you have high bills please pay them");
            }


        }
        /// <summary>
        /// to add bills rent just no electricity or other bills 
        /// </summary>

        public override void otherBills()
        {
            
                monthlyBills += rentBills;
           
                

               Console.WriteLine("add new bill .");
            
        }

        /// <summary>
        /// return the market type
        /// </summary>
        /// <returns> the market type</returns>
        public override string placeTypes()
        {

            string stringType = $"place Type park games";
            return stringType;
        }
    }
}
