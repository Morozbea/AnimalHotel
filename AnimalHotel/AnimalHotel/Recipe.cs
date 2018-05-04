using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    public class Recipe
    {
        private ListManager<string> m_ingredients;
        private string m_name;              
        public Recipe(string name,ListManager<string> lista)
        {
            m_ingredients = new ListManager<string>();
            m_name = String.Empty;
            m_name = name;
            m_ingredients = lista;           
        }
        //Property forn name of the recipe
        public string Name { get { return m_name; } set { m_name = value; } }
        //Print Recipes
        public override string ToString()
        {
            string a = "";
            foreach (string a1 in m_ingredients)
            {
                a += a1 + ",";
            }
            return string.Format(" {0}   {1}", Name, a);
        }
    }
}
