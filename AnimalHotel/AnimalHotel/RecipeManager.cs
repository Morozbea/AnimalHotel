using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class RecipeManager : ListManager<Recipe>
    {
        List<string> ingList;
        //making use of the ListManager
        public RecipeManager()
        {
            ingList = new List<string>();

        }       

        public void ChangeIng()
        {
            
        }

    }
}
