using System;
using System.Collections.Generic;
using System.IO;

namespace Module_8
{


    class BinaryRW
    {
        private const string filePath = @"C:\Users\pc\Desktop\BinaryFile.bin";





        internal static void fileReader()
        {

            


            string information = "";


            try
            {
                using (BinaryReader br = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    information = br.ReadString();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            Console.WriteLine(information);
        }



        internal static void fileWrite()
        {
            try
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open(filePath, FileMode.Append)))
                {
                    bw.Write("\n Файл изменен " + DateTime.Now + " на компьютере " + Environment.OSVersion);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }




    }


    class Program
    {
        static void Main(string[] args)
        {

            BinaryRW.fileReader();
            BinaryRW.fileWrite();
        }
    }
}

