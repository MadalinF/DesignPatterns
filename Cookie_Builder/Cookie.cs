using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieBuilder
{
    class Cookie
    {
        public string name;
        public string cakeReceipe;
        public string frostingReceipe;

        public Cookie()
        {
            name = "";
            cakeReceipe = "";
            frostingReceipe = "";
        }

        public string GetReceipe()
        {
            return name + "For Cake: " + cakeReceipe + "For Frosting: " + frostingReceipe;
        }
    }
}