using System;

namespace Exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            if (args.Length != 0)
            {
                if (args[0] == "1") { E1 e1 = new E1(); }
                if (args[0] == "2") { E2 e2 = new E2(); }
                if (args[0] == "3") { E3 e3 = new E3(); }
                if (args[0] == "4") { E4 e4 = new E4(); }
                if (args[0] == "5") { E5 e5 = new E5(); }
                if (args[0] == "6") { E6 e6 = new E6(); }
                if (args[0] == "7") { E7 e7 = new E7(); }
                if (args[0] == "8" || args[0] == "9") { E8 e89 = new E8(); }
                if (args[0] == "10") { E10 e10 = new E10(); }
                if (args[0] == "11") { E11 e11 = new E11(); }
                if (args[0] == "12") { E12 e12 = new E12(); }
                if (args[0] == "13") { E13 e13 = new E13(); }
                if (args[0] == "14") { E14 e14 = new E14(); }
                if (args[0] == "15") { E15 e15 = new E15(); }
                if (args[0] == "16") { E16 e16 = new E16(); }
                if (args[0] == "17") { E17 e17 = new E17(); }
                if (args[0] == "18") { E18 e18 = new E18(); }
                if (args[0] == "19") { E19 e19 = new E19(); }
                if (args[0] == "20") { E20 e20 = new E20(); }
                if (args[0].ToLower() == "storage") { p.StorageModule(); }
            }
            else
            {
                throw new Exception("Invalid argument");
            }
        }

        public void StorageModule()
        {
            File f1 = new File(650, "Todos.txt", false, false, false);
            File f2 = new File(86_000_000, "GTAV.exe", false, false, false);
            File f3 = new File(950, "sajt.txt", false, false, false);
            /* s.AddFile(f);
            System.Console.WriteLine(s.SearchFile("Joska.txt").Size); */
            Floppy floppy = new Floppy();
            floppy.AddFile(f1);
            DVD dvd = new DVD();
            DVDRW dvdrw = new DVDRW();
            //dvdrw.AddFile(f1);
            //dvdrw.AddFile(f3);
            System.Console.WriteLine(dvdrw.GetMaximumCapacity());
            System.Console.WriteLine(dvdrw.GetReservedCapacity());
            dvdrw.Open();
            System.Console.WriteLine(dvdrw.GetReservedCapacity());
            HDD hdd1 = new HDD(1_000_000_000);
            HDD hdd2 = new HDD();
            System.Console.WriteLine($"{hdd1.GetMaximumCapacity()}");
            //hdd1.AddFile(f2);
            System.Console.WriteLine("HDD 1 reserved capacity: {0}", hdd1.GetReservedCapacity());

            Computer comp1 = new Computer("Zsoli PC");
            comp1.Mount(floppy);
            comp1.Mount(hdd1);
            //comp1.Mount(hdd2);
            System.Console.WriteLine(floppy.SearchFile(f1.Name).Name);
            System.Console.WriteLine("Max capacity (COMP1): {0}", comp1.GetAllDrivesMaximumCapacity());
            System.Console.WriteLine("Free capacity (COMP1): {0}", comp1.GetAllDrivesFreeCapacity());
            System.Console.WriteLine("Reserved capacity (COMP1): {0}", comp1.GetAllDrivesReservedCapacity());

            //System.Console.WriteLine("Drives: \n" + comp1.GetDrives());

            //comp1.Archive(hdd1, f1);
            comp1.Archive(f1);
            System.Console.WriteLine("New HDD1 reserved capacity: {0}", hdd1.GetReservedCapacity());

            //dvd.Lock();
            //floppy.Lock();
            //floppy.AddFile(f1);
            //dvd.AddFile(f1);
            //dvd.Lock();
            //System.Console.WriteLine(dvd.GetFreeCapacity());
            //System.Console.WriteLine(dvd.GetReservedCapacity());
        }
    }
}