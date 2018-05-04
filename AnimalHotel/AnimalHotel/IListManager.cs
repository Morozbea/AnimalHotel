using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    public interface IListManager<T>
    {        
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
        //Implemented for being able to iterate through the list (ListManager<string>) in recipe and staff
        IEnumerator<T> GetEnumerator();        
    }
}
