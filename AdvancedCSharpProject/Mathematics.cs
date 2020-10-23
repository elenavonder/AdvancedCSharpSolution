using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharpProject
{
    //generic class type
    public class Mathematics<T>
    {
        T[] collection = new T[10];
        int NbrOfItems = 0;
        public void Add (T item)
        {
            if (collection.Length >= 10)
                return;
            collection[NbrOfItems] = item;
            NbrOfItems++;
        }
    }
}
