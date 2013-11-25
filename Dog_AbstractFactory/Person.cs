using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogSimulator
{
    abstract class Person
    {
        protected Dog dog;
        protected Leash leash;

        public abstract DogShop GetTheShop();

        public void BuyADog()
        {
            DogShop shop = GetTheShop();
            dog = shop.GetADog();
            leash = shop.GetALeash();
        }

        public void PlayWithTheDog()
        {
            dog.Bark();
        }
    }

    class Adult : Person
    {
        public override DogShop GetTheShop()
        {
            return new BigDogShop();
        }
    }

    class Child : Person
    {
        public override DogShop GetTheShop()
        {
            return new NormalDogShop();
        }
    }
}
