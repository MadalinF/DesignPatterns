using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DogSimulator;

namespace TestDogSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person adult = new Adult();
            Person child = new Child();

            adult.BuyADog();
            child.BuyADog();

            adult.PlayWithTheDog();
            child.PlayWithTheDog();
        }
    }
}
