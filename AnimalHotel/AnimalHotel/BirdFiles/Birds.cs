using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    abstract class Birds : Animal
    {
        private int m_lengthOfWings;
        
        //Default Constructor
        public Birds()
        {
            m_lengthOfWings = 0;            
        }

        //Inherite from the Animal classen and add the length of wings variable
        public Birds(string name, int age, Gender gender, int wingLength) : base (name,age,gender)
        {
            m_lengthOfWings = wingLength;
        }

        //Property
        public int WingsLength { get { return m_lengthOfWings; } set { m_lengthOfWings = value; } }

        //Format info into string and return string
        public override string ToString()
        {
            return string.Format("{0}                     Wingslength: {1}", base.ToString(), WingsLength);
        }
    }
}
