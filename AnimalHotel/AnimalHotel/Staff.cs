using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    public class Staff
    {
        private string m_name;
        private IListManager<string> m_staff_list;
        public Staff(string name, ListManager<string> lista)
        {
            m_staff_list = new ListManager<string>();
            m_name = String.Empty;
            m_name = name;
            m_staff_list = lista;
        }
        //Property for name of the staff
        public string Name { get { return m_name; } set { m_name = value; } }
        //Print the name
        public override string ToString()
        {
            string a = "";
            foreach (string item in m_staff_list)
            {
                a += item + ",";
            }
            return string.Format(" {0} {1}", Name, a);
        }
    }
}
