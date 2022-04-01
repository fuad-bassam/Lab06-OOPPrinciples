using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Markets : Places,IIsOpen
    {
        protected decimal monthlyBills;
        protected decimal rentBills;



        /// <summary>
        /// write the place is close
        /// </summary>
        public void close()
        {
            Console.WriteLine($"{placeName} is close");       
        
        }

        /// <summary>
        /// write the place is open
        /// </summary>
        public void opan()
        {
            Console.WriteLine($"{placeName} is open");
        }

       
        /// <summary>
        /// set the rent for the place
        /// </summary>
        /// <param name="rent"></param>
        public void setRentBills(decimal rent) {

            rentBills = rent;
        
        }
        /// <summary>
        /// set all bills
        /// </summary>
        public abstract void otherBills();

        /// <summary>
        ///  print the status of the bills is ok or high
        /// </summary>
        public abstract void billsLinit();

        /// <summary>
        /// if user pay for his bills
        /// </summary>
        /// <param name="pay"> the money they paid</param>
        public void payBills(decimal pay) {

            decimal num = monthlyBills - pay;
            if (num<=0m)
            {
                Console.WriteLine($"The bill has been paid in full , remaining for you {num}");
            }
            else
            {
                Console.WriteLine($"you paid {pay} , still on you {num}");
            }

       
        
        }


    }
}
