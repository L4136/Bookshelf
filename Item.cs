using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshelf
{
    class Item
    {
        public string name2;
        public bool used2;
        public int year2;
        

        public Item(string name, bool used, int year)
        {
            name2 = name;
            used2 = used;
            year2 = year;
            
        }

        public override string ToString()
        {
            return "Item: | Name: " + name2 + " | Year: " + year2 + " | Used: " + used2 ;
        }
    }
}
