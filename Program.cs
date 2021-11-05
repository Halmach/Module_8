using System;
using System.Collections.Generic;
using System.IO;

namespace Module_8
{


    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\pc\source\dev\Module_8\Module_8\Program.cs";
      //      FileInfo file = new FileInfo(filePath);
           
            if (File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine("// " + Convert.ToString(DateTime.Now));
                    sw.Close();
                }
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
            }









































            /*
          //  DriveInfo[] drives = DriveInfo.GetDrives();

          //  foreach (DriveInfo drive in drives)
          //  {
          //      Console.WriteLine($"Название: {drive.Name}");
          //      Console.WriteLine($"Тип: {drive.DriveType}");
          //      if (drive.IsReady)
          //      {
          //          Console.WriteLine($"Объем:{drive.TotalSize}");
          //          Console.WriteLine($"Свободно:{drive.TotalFreeSpace}");
          //          Console.WriteLine($"Метка:{drive.VolumeLabel}");

          //      }
          //  }*/

            ////  GetCatalogs();
            //string dirName = @"C:\testFolder";
            //string subDirName = @"Splinter Cell\Double_Agent";

            //try
            //{
            //      Console.WriteLine("Папка не создана");
            //      DirectoryInfo newDirectory = new DirectoryInfo(dirName); 
            //      if(!newDirectory.Exists) newDirectory.Create();

            //      newDirectory.MoveTo(@"C:\$Recycle.Bin\S-1-5-21-2602286027-2564388254-2951404948-1001\testFloder");
            //      //else Console.WriteLine(newDirectory.GetDirectories().Length + newDirectory.GetFiles().Length);
            //      //Console.WriteLine("Папка  создана");
            //      //Console.WriteLine(newDirectory.GetDirectories().Length + newDirectory.GetFiles().Length);
            //      //Console.WriteLine("Создана вложенная папка");
            //      //newDirectory.CreateSubdirectory(subDirName);
            //      //Console.WriteLine(newDirectory.GetDirectories().Length + newDirectory.GetFiles().Length);



            //      //Console.WriteLine($"Название каталога: {newDirectory.Name}");
            //      //Console.WriteLine($"Полное название каталога: {newDirectory.FullName}");
            //      //Console.WriteLine($"Время создания каталога: {newDirectory.CreationTime}");
            //      //Console.WriteLine($"Корневой каталог: {newDirectory.Root}");


            //    //  newDirectory.Delete(true);
            //    //  Console.WriteLine("Каталог удален");

            //  }
            //catch (Exception e)
            //{
            //      Console.WriteLine(e.Message);


        }

        //static void GetCatalogs()
        //{
        //    int fileCnt = 0;
        //    int directoryCnt = 0;
        //    string dirName = @"C://";
        //    if (Directory.Exists(dirName))
        //    {
        //     //   Console.WriteLine("Папки:");
        //        string[] dirs = Directory.GetDirectories(dirName);
        //        foreach (string d in dirs)
        //        {
        //            // Console.WriteLine(d);
        //            fileCnt++;
        //        }
        //  //      Console.WriteLine("Файлы:");
        //        string[] files = Directory.GetFiles(dirName);
        //        foreach (string s in files)
        //        {
        //            //  Console.WriteLine(s);
        //            directoryCnt++;
        //        }
        //    }
        //    Console.WriteLine("File num: " + fileCnt);
        //    Console.WriteLine("Directory num: " + directoryCnt);
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
// 05.11.2021 23:30:14
// 05.11.2021 23:31:18
