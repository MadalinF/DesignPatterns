using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogSimulator
{
    class Leash
    {
        protected int size;

        public Leash()
        {
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }
    }

    class MediumSizeLeash : Leash
    {
        public MediumSizeLeash()
            :base()
        {
            size = 25;
        }
    }

    class BigSizeLeash : Leash
    {
        public BigSizeLeash()
            : base()
        {
            size = 100;
        }
    }
}