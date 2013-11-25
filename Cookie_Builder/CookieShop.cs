using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieBuilder
{
    class CookieShop
    {
        public Cookie GetCookie(CookieBuilder builder)
        {
            builder.BakeCake();
            builder.PrepareFrosting();

            return builder.GetCookie();
        }
    }
}
