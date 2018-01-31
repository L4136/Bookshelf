using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshelf
{
    class Paper : Item
    {
        private bool hardcover2;
        private int pages2;
        private string type2;

        public Paper(string name,  int year, bool used, string type, bool hardcover, int pages)
            : base(name, used, year)
        {
            pages2 = pages;
            hardcover2 = hardcover;
        }
        
        public override string ToString()
        {
            return base.ToString() + " | Type: " + type2 + " | Hard cover: " + hardcover2 + " | Pagecount: " + pages2;
        }
    }
}
