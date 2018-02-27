using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    abstract class Mammals : Animal
    {
        int m_nrOfTooth;

        //Default Constructor
        public Mammals() 
        {
            m_nrOfTooth = 0;
        }

        //Inherite from the Animal classen and add the number of teeth variable
        public Mammals(string name, int age, Gender gender, int teeth ):base(name,age,gender)
        {
            m_nrOfTooth = teeth;
        }

        //Properties
        public int NumberOfTooth { get { return m_nrOfTooth; } set { m_nrOfTooth = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format("{0}               Number of tooth: {1}", base.ToString(), NumberOfTooth);
        }

    }
}
