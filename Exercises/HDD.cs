using System;

namespace Exercises
{
    class HDD : Storage
    {
        public HDD() : base(500_000_000)   //Default
        {

        }

        public HDD(int capacity) : base(capacity)
        {
        }
    }
}