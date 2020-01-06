using System;
using System.Collections.Generic;

namespace Exercises
{
    class Computer
    {
        List<Storage> storages;
        public string Title { get; set; }
        public Computer(string title)
        {
            Title = title;
            storages = new List<Storage>();
        }

        public string GetDrives()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string str = "";
            foreach (var storage in storages)
            {
                if (!dict.ContainsKey(storage.GetType().Name))
                {
                    dict.Add(storage.GetType().Name, 1);
                }
                else
                {
                    dict[storage.GetType().Name] += 1;
                }
            }
            foreach (KeyValuePair<string, int> pair in dict)
            {
                str += String.Format($"{pair.Key}:  {pair.Value}\n");
            }
            return str;
        }

        public void Mount(Storage storage)
        {
            storages.Add(storage);
        }

        public int GetAllDrivesMaximumCapacity()
        {
            int sum = 0;
            foreach (var storage in storages)
            {
                sum += storage.GetMaximumCapacity();
            }
            return sum;
        }

        public int GetAllDrivesFreeCapacity()
        {
            int sum = 0;
            foreach (var storage in storages)
            {
                sum += storage.GetFreeCapacity();
            }
            return sum;
        }

        public int GetAllDrivesReservedCapacity()
        {
            int sum = 0;
            foreach (var storage in storages)
            {
                sum += storage.GetReservedCapacity();
            }
            return sum;
        }

        public void Archive(Storage storage, File file)
        {
            bool found = false;
            if (storages.Contains(storage))
            {
                if (storage.GetFreeCapacity() >= file.Size)
                {
                    foreach (var _storage in storages)
                    {
                        if (_storage.SearchFile(file.Name) == file)
                        {
                            storage.AddFile(file);
                            System.Console.WriteLine("Archived & added to storage!");
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        throw new Exception("File does not exist!");
                }
                else
                {
                    System.Console.WriteLine("Storage is full! ({0})", storage.GetReservedCapacity());
                }
            }
            else
            {
                throw new Exception("Couldn't find the storage!");
            }
        }

        public void Archive(File file)
        {
            bool found = false;

            foreach (var storage in storages)
            {
                if (storage.SearchFile(file.Name) == file)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
                throw new Exception("File does not exist!");
            found = false;
            foreach (var storage in storages)
            {
                if (storage.GetFreeCapacity() >= file.Size && !storage.Files.Contains(file))
                {
                    storage.AddFile(file);
                    System.Console.WriteLine("Archived & added to storage! {0}", storage.GetType().Name);
                    found = true;
                    break;
                }
            }
            if (!found)
                throw new Exception("Couldn't find a free storage!");
        }
    }
}