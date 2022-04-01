using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class Predator : Animals
    {

        protected string notOkWith = null;

        protected override string Sex { get ; set ; }
        protected override int SizePerUnit { get; set; }

        public override void eat()
        {

            Console.WriteLine($"animals eats meals");


        }


        public bool isokWith(Animals animal) {




            if (animal.getType() == "Prey")
            {
                return false;
            }
            else
            {
                return true;
            }


        }


    }
}
