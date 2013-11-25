using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieBuilder
{
    class CookieBuilder
    {
        protected Cookie cookie;

        public CookieBuilder()
        {
            cookie = new Cookie();
        }

        public virtual void BakeCake()
        {
        }

        public virtual void PrepareFrosting()
        {
        }

        public Cookie GetCookie()
        {
            return cookie;
        }
    }

    class BrownieBuilder : CookieBuilder 
    {
        public override void BakeCake()
        {
            cookie.cakeReceipe = @"
                                       - 1 cup oil
                                       - 2 cups sugar
                                       - 2 teaspoons vanilla
                                       - 2 cups flour
                                       - 1 cup cocoa powder
                                       - 1 teaspoon salt
                                      ";
        }

        public override void PrepareFrosting()
        {
            cookie.frostingReceipe = @"
                                       - 6 tablespoons cocoa powder
                                       - 1 cup margarine
                                       - 2 cups sugar
                                       - 1 cup milk
                                       - 1 teaspoon vanilla
                                      ";
        }
    }
}