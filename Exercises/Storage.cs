using System;
using System.IO;
using System.Collections.Generic;

namespace Exercises
{
    class Storage
    {
        public readonly int MaxCapacity;
        public bool ReadOnly { get; protected set; }
        public int ReservedCapacity { get; protected set; }
        public List<File> Files;

        public Storage(int maxCapacity)
        {
            ReadOnly = false;
            MaxCapacity = maxCapacity;
            ReservedCapacity = 0;
            Files = new List<File>();
        }

        public int GetMaximumCapacity()
        {
            return MaxCapacity;
        }

        public int GetFreeCapacity()
        {
            return MaxCapacity - ReservedCapacity;
        }

        public int GetReservedCapacity()
        {
            return ReservedCapacity;
        }

        public virtual void Format()
        {
            if (ReadOnly)
                throw new Exception($"{this.GetType().Name} is read-only!");

            ReservedCapacity = 0;
            Files.Clear();
        }

        public virtual void AddFile(File file)
        {
            if (ReadOnly)
                throw new Exception($"{this.GetType().Name} is read-only!");

            if (!Files.Contains(file) && file.Size + ReservedCapacity <= MaxCapacity)
            {
                ReservedCapacity += file.Size;
                Files.Add(file);
            }
            else
            {
                throw new Exception("File not found!");
            }
        }

        public virtual void RemoveFile(File file)
        {
            if (ReadOnly)
                throw new Exception($"{this.GetType().Name} is read-only!");

            if (Files.Contains(file))
            {
                ReservedCapacity -= file.Size;
                Files.Remove(file);
            }
            else
            {
                throw new Exception("File not found!");
            }
        }

        public File SearchFile(string fileName)
        {
            foreach (var file in Files)
            {
                if (file.Name == fileName)
                {
                    return file;
                }
            }
            throw new Exception("File not found!");
        }
    }
}