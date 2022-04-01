using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Prey : Animals
    {


        protected override string Sex { get; set; }
        protected override int SizePerUnit { get; set; }

        public override void eat()
        {

            Console.WriteLine($"animals eats");


        }

        public void conPlayWith()
        {

            int hour = Convert.ToInt32( DateTime.Now.ToString("HH"));



            if (hour <= 8 )
            {
                Console.WriteLine($"Can play");

            }
            else
            {
                Console.WriteLine($"Can NOT play");
            }


        }
    }
}
