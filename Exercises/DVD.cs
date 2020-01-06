using System;

namespace Exercises
{
    class DVD : Storage
    {
        public DVD() : base(4700)
        {
        }

        public void Lock()
        {
            ReadOnly = true;
            ReservedCapacity = MaxCapacity;
        }
    }
}