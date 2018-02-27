using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class Staff
    {
        string name;
        List<string> staff_list;

        public Staff()
        {

        }

        public string Name { get { return name; } set { name = value; } }

        public List<string> List_Of_Straff { get { return staff_list; } set { staff_list = value; } }
    }
}
