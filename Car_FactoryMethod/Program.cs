using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver sd = new SpeedyDriver();
            Driver lad = new LawAbidingDriver();

            sd.Drive();
            lad.Drive();
        }
    }
}
