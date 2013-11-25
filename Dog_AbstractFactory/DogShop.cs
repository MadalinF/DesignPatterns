using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogSimulator
{
    abstract class DogShop
    {
        public abstract Dog GetADog();
        public abstract Leash GetALeash();
    }

    class NormalDogShop : DogShop
    {
        public override Dog GetADog()
        {
            return new SiberianHusky();
        }

        public override Leash GetALeash()
        {
            return new MediumSizeLeash();
        }
    }

    class BigDogShop : DogShop
    {
        public override Dog GetADog()
        {
            return new SaintBernard();
        }

        public override Leash GetALeash()
        {
            return new BigSizeLeash();
        }
    }
}
