using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    abstract class Animal : IAnimal//, IComparable<Animal>
    {
        //fields    
        private string m_name;
        private int m_age;
        private Gender m_animal_gender;
        private int m_id;

        //Default constructor
        public Animal()
        {
            m_name = string.Empty;
            m_age = 0;
        }

        // Constructor with 3 parameters
        public Animal(string name, int age, Gender anim_gender)
        {
            m_name = name;
            m_age = age;
            m_animal_gender = anim_gender;
        }

        //Properties
        public string Name { get { return m_name; } set { m_name = value; } }

        public int Age { get { return m_age; } set { m_age = value; } }

        public Gender GenderOfAnimal { get { return m_animal_gender; } set { m_animal_gender = value; } }

        public int Id { get { return m_id; } set { m_id = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format("    {0}                    {1}                           {2}                        {3}", GetSpecies() + Id, Name, Age, GenderOfAnimal.ToString());
        }


        //Abstrackt Methods
        public abstract EaterType GetEaterType();

        public abstract string GetSpecies();

        public abstract FoodSchedule GetFoodSchedule();

    }
}
