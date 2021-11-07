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








    }


    class Program
    {
        static void Main(string[] args)
        {

            BinaryRW.fileReader();
        }
    }
}

