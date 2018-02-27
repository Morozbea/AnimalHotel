using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class Deer : Mammals
    {
        string m_lengthOfTails;

        //Default constructor
        public Deer()
        {
            m_lengthOfTails = string.Empty;
        }

        //Inherite from the Birds class and add the special length of tail variable
        public Deer(string name, int age, Gender gender, int teeth, string tail) : base(name, age, gender, teeth)
        {
            m_lengthOfTails = tail;
        }

        //Property
        public string LengthOfTail { get { return m_lengthOfTails; } set { m_lengthOfTails = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format("{0}                Length of tail: {1}", base.ToString(), LengthOfTail);
        }

        //Return the eatertype of the Deer
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }

        //Return that this animal is a Deer
        public override string GetSpecies()
        {
            string specie = "Deer";
            return specie;
        }

        //Add a foodschedule to the Deer
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Deer Food Schedule: Morning: Afternoon: Evening: ");
            return foodSchedule;
        }
    }
}

