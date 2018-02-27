using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class Eagle : Birds
    {
        string m_birdType;               
        
        //Default constructor
        public Eagle()
        {
            m_birdType = string.Empty;
        }

        //Inherite from the Birds class and add the special birdtype variable
        public Eagle(string name, int age, Gender gender, int wingLength, string birdType) : base(name, age,gender,wingLength)
        {
            m_birdType = birdType;
        }

        //Property
        public string BirdType { get { return m_birdType; } set { m_birdType = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format("{0}             Birdtype: {1}", base.ToString(), BirdType) ;
        }

        //Return the eatertype of the Eagle
        public override EaterType GetEaterType()
        {            
            return EaterType.Carnivore;
        }
        
        //Return that this animal is a eagle
        public override string GetSpecies()
        {
            string specie = "Eagle";
            return specie;
        }

        /// <summary>
        ///  Add a foodschedule to the eagle
        /// </summary>
        /// <returns></returns>
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule foodSchedule = new FoodSchedule();            
            foodSchedule.AddFoodScheduleItem("Eagle Food Schedule: Morning: Afternoon: Evening: ");
            return foodSchedule;
        }
    }
}
