﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHotel
{
    class ListManager<T> : IListManager<T>//, IComparable<Animal>
    {
        private List<T> list;
   
        public ListManager()
        {
            list = new List<T>();
         
        }

        //int IComparable<Animal>.CompareTo(Animal obj1)
        //{
        //    if (this.Age > obj1.Age) return 1;
        //    if (this.Age == obj1.Age) return 0;
        //    if (this.Age < obj1.Age) return -1;
        //    return (0);
        //}

        //Fields
        public List<T> m_list { get; set; }

        //Properties
        public int Count { get; }

        //Methods
        public void Add(T aType)
        {
            if (list != null)
            {              
                list.Add(aType);

            }
        }
        public void ChangeAt(T aType, int anIndex)
        {
            list.RemoveAt(anIndex);
            list.Insert(anIndex, aType);
        }
        public void CheckIndex(int index)
        {

        }
        public void DeleteAll()
        {

        }
        public void DeleteAt(int anindex)
        {
            list.RemoveAt(anindex);
        }
        public T GetAt(int anindex)
        {

            return list[anindex];
        }
        public string[] ToStringArray()
        {
            string[] list_List = new string[list.Count];
            int number = 0;
            foreach (T item in list)
            {
                list_List[number++] = item.ToString();
            }
            return list_List;
        }
        //public List<string> ToListString()
        //{

        //}

        public void Sort(IComparer<T> sorter)
        {
            list.Sort(sorter);
        }
    }
}
