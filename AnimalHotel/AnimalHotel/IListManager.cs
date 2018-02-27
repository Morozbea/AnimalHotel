using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    interface IListManager<T> 
    {
        //Fields
       

        //Properties
        int Count { get; }

        //Methods
        void Add(T aType);
        void ChangeAt(T aType, int anIndex);
        void CheckIndex(int index);
        void DeleteAll();
        void DeleteAt(int anindex);
        //T GetAt(int anindex);
        string[] ToStringArray();
        //List<string> ToListString();

    }
}
