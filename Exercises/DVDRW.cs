using System;

namespace Exercises
{
    class DVDRW : DVD
    {
        public DVDRW() : base()
        {
        }

        public void Open()
        {
            ReservedCapacity = 0;
        }
    }
}