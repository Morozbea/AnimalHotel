using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class Duck : Birds
    {
        string m_birdType;

        //Default constructor
        public Duck()
        {
            m_birdType = string.Empty;
            
        }

        //Inherite from the Birds class and add the special birdtype variable
        public Duck(string name, int age, Gender gender, int wingLength, string birdType) : base(name, age,gender,wingLength)
        {
            m_birdType = birdType;
        }

        //Property
        public string BirdType { get { return m_birdType; } set { m_birdType = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format("{0}             Birdtype: {1}", base.ToString(), BirdType);
        }

        //Return the eatertype of the Duck
        public override EaterType GetEaterType()
        {
            return EaterType.Omnivorous;
        }

        //Return that this animal is a duck
        public override string GetSpecies()
        {
            string specie = "Duck";
            return specie;
        }

        //Add a foodschedule to the duck
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Duck Food 'Schedule: Morning: Afternoon: Evening: ");
            return foodSchedule;
        }
    }
}
