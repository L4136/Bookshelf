using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshelf
{
    class Digital : Item
    {
        private string type2;
        private string console2;
        private bool multi2;


        public Digital(string name, int year, bool used,  string type, string console, bool multi )
            :base(name, used, year)
        {
            type2 = type;
            console2 = console;
            multi2 = multi;
        }

        // return Person data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return base.ToString() + " | Type: " + type2 + " | Console: " + console2 + " | Multiplayer: " + multi2 ;
        }
    }
}
