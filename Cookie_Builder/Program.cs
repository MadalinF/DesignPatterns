using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CookieShop cs = new CookieShop();
            CookieBuilder cb = new BrownieBuilder();

            Cookie c = cs.GetCookie(cb);

            System.Diagnostics.Trace.WriteLine(c.GetReceipe());
        }
    }
}
