﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем:{drive.TotalSize}");
                    Console.WriteLine($"Свободно:{drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка:{drive.VolumeLabel}");

                }
            }

            GetCatalogs();
        }

        static void GetCatalogs()
        {
            string dirName = @"C://";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string d in dirs)
                {
                    Console.WriteLine(d);
                }
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
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
