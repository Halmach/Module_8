using System;

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


        public string DiskName => diskName;

        public int DiskSize => diskSpace;

        public int FreeSize => freeSpace;

        public Disk(string diskName,int diskSpace,int freeSize)
        {
            this.diskSpace = diskSpace;
            this.diskName = diskName;
            this.freeSpace = freeSize;
        }
    }
}
