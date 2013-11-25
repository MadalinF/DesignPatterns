using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogSimulator
{
    abstract class Dog
    {
        protected string countryOfOrigin;

        public Dog()
        {
            countryOfOrigin = "unknown";
        }

        public string GetOrigin()
        {
            return countryOfOrigin;
        }

        public abstract void Bark();
    }

    class SiberianHusky : Dog
    {
        public SiberianHusky()
            :base()
        {
            countryOfOrigin = "Siberia, Russia";
        }

        public override void Bark()
        {
            System.Diagnostics.Trace.WriteLine("Hoooooowwwwl!");
        }
    }

    class SaintBernard : Dog
    {
        public SaintBernard()
            :base()
        {
            countryOfOrigin = "Italy, Switzerland";
        }

        public override void Bark()
        {
            System.Diagnostics.Trace.WriteLine("ham...!");
        }
    }
}