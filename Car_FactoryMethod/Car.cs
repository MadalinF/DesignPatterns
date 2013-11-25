using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
    abstract class Car
    {
        public abstract int GetTopSpeed();
    }

    class McLarenF1 : Car
    {
        public override int GetTopSpeed()
        {
            return 370;
        }
    }

    class Oltcit : Car
    {
        public override int GetTopSpeed()
        {
            return 70;
        }
    }
}
