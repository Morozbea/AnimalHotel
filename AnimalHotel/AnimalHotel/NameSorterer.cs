using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class NameSorterer : IComparer<Animal>
    {
        //Default Constructor
        public NameSorterer()
        {

        }

        //Sort animals after name
        public int Compare(Animal obj1, Animal obj2)
        {
            return obj1.Name.CompareTo(obj2.Name);
        }
    }
}
