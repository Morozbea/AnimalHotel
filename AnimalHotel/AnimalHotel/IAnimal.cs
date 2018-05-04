using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    public interface IAnimal
    {
        /// <summary>
        /// method
        /// </summary>
        /// <returns></returns>
        EaterType GetEaterType();

        /// <summary>
        /// method
        /// </summary>
        /// <returns></returns>
        FoodSchedule GetFoodSchedule();

        /// <summary>
        /// returns a type of species like dog, cat...
        /// </summary>
        /// <returns></returns>
        string GetSpecies();

        /// <summary>
        /// returns a gender
        /// </summary>
        /// <returns></returns>
        Gender GenderOfAnimal { get; set; }

        /// <summary>
        /// returns an ID
        /// </summary>
        /// <returns></returns>
        int Id { get; set; }

        /// <summary>
        /// returns a Name
        /// </summary>
        /// <returns></returns>
        string Name { get; set; }
    }
}
