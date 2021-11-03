using System;
using System.Collections.Generic;

namespace Module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Disk
    {
        private string diskName;
        private int diskSpace;
        private int freeSpace;
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public string DiskName => diskName;

        public int DiskSize => diskSpace;

        public int FreeSize => freeSpace;

        public Disk(string diskName,int diskSpace,int freeSize)
        {
            this.diskSpace = diskSpace;
            this.diskName = diskName;
            this.freeSpace = freeSize;
        }
        public void CreateDirectory(string nameDirectory)
        {
            Folders.Add(nameDirectory, new Folder());
        }
    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();

      
    }
}
