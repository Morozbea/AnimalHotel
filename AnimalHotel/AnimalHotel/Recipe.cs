using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class Recipe 
    {
        private List<string> m_ingredients;
        private string m_name;
        int numberOfIngredients;
        public Recipe(string name,List<string> lista)
        {
            m_ingredients = new List<string>();
            m_name = String.Empty;
            numberOfIngredients = 0;
            m_name = name;
            m_ingredients = lista;
        }

        //Properties
        public List<string> Ingredients { get { return m_ingredients; } }
        public string Name { get { return m_name; } set { value = m_name; } }

        public int NrOfIngr { get { return numberOfIngredients; } }            

       
    }
}
