using System;

namespace Exercises
{
    class Floppy : Storage
    {
        public Floppy() : base(1440)
        {
        }

        public void Lock()
        {
            ReadOnly = true;
        }

        public void Unlock()
        {
            ReadOnly = false;
        }
    }
}