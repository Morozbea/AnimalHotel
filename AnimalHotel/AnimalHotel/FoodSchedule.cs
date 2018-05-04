using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    public class FoodSchedule
    {
        List<string> m_foodDescriptionScript = new List<string>();
        int sg;

        //Default constructor
        public FoodSchedule()
        {
            sg = 0;
        }

        //Number of items int the list
        public int Count { get { return sg; } }
    
        /// <summary>
        /// Methoder done!
        /// Add Foodshcedule to the list
        /// </summary>
        /// <param name="item"></param>
        public void AddFoodScheduleItem(string item)
        {
            m_foodDescriptionScript.Add(item);
            sg++;
        }
        //Done Methods but not used
        //Change a food schedule
        public void ChangeFoodScheduleItem(string item, int index)
        {
            m_foodDescriptionScript.RemoveAt(index);
            m_foodDescriptionScript.Insert(index, item);
        }

        //Delete a food schedule
        public void DeleteFoodScheduleItem(int index)
        {
            m_foodDescriptionScript.RemoveAt(index);
        }

        //Return an array of strings where every string represents a contact
        public string[] GetFoodSchedule()
        {
            string[] schema = new string[m_foodDescriptionScript.Count];
            int number = 0;
            foreach (string item in m_foodDescriptionScript)
            {
                schema[number++] = item.ToString();
            }
            return schema;
        }
    }
}
