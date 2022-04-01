using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public abstract class Places
    {
        protected int placeNum;
        protected float placeSize;
        protected String placeName;
        protected String placeType;

        public String getSize() {

            String size=$"the {placeName} size is {placeSize}";
            return size;
        }

        public abstract string placeTypes();
    }
}
