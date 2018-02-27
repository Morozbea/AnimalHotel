using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class AgeSorter : IComparer<Animal>
    {
        //Default Constructor
        public AgeSorter()
        {

        }

        //Sort Animals after ages
        public int Compare(Animal obj1, Animal obj2)
        {
            if (obj1.Age > obj2.Age) return 1;
            if (obj1.Age == obj2.Age) return 0;
            if (obj1.Age < obj2.Age) return -1;
            return 0;
        }
    }

}