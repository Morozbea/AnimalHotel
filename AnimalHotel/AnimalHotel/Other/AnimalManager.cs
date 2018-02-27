using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Beatrix Moroz, 2018.01.14.

namespace AnimalHotel
{
    //To create an object of the species selected by the user on the GUI, you must use dynamic binding(or late binding, refer to course material)
    class AnimalManager : ListManager<Animal>
    {
        private int ID;

        //Default constructor
        public AnimalManager()
        {
            ID = 0;
        }

        public void AddAnimal(Animal anim)
        {
            anim.Id = ID++;
            Add(anim);
        }
    }
}
