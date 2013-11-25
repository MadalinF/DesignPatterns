using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
    abstract class Driver
    {
        protected abstract Car FindACar();

        public void Drive()
        {
            Car car = FindACar();

            System.Diagnostics.Trace.WriteLine("Driving at top speed: " + car.GetTopSpeed() + " km/h");
        }
    }

    class SpeedyDriver : Driver
    {
        protected override Car FindACar()
        {
            return new McLarenF1();
        }
    }

    class LawAbidingDriver : Driver
    {
        protected override Car FindACar()
        {
            return new Oltcit();
        }
    }
}
