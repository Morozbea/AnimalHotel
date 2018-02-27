﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class Cat : Mammals
    {
        string m_lengthOfTails;

        //Default constructor
        public Cat()
        {
            m_lengthOfTails = string.Empty;
            
        }

        //Inherite from the Birds class and add the special length of tail variable
        public Cat(string name, int age, Gender gender, int teeth, string tail) : base(name, age, gender, teeth)
        {
            m_lengthOfTails = tail;
        }

        //Property
        public string LengthOfTail { get { return m_lengthOfTails; } set { m_lengthOfTails = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format(" {0}          Length of tail: {1}", base.ToString(), LengthOfTail);
        }

        //Return the eatertype of the Cat
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }

        //Return that this animal is a cat
        public override string GetSpecies()
        {
            string specie = "Cat";
            return specie;
        }

        //Add a foodschedule to the cat
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule foodSchedule = new FoodSchedule();
            foodSchedule.AddFoodScheduleItem("Cat Food Schedule: Morning: Afternoon: Evening: ");
            return foodSchedule;
        }
    }
}
