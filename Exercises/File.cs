using System;

namespace Exercises
{
    class File
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public bool ReadOnly { get; set; }
        public bool System { get; set; }
        public bool Hidden { get; set; }

        public File(int size, string name, bool readOnly, bool system, bool hidden)
        {
            Size = size;
            Name = name;
            ReadOnly = readOnly;
            System = system;
            Hidden = hidden;
        }
    }
}