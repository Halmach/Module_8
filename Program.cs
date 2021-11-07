using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Module_8
{
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class BinaryRW
    {
        private const string filePath = @"C:\Users\pc\Desktop\BinaryFile.bin";

        internal static string SerializateObject(object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("myContacts.dat",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs,obj);
                Console.WriteLine("Объект сериализован");
            }

            return "myContacts.dat";
        }

        internal static object  DeserializateObject(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    var someObject = formatter.Deserialize(fs);
                    Console.WriteLine("Объект десериализован");
                    return someObject;

                }
            }
            else return null;
        }

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
            Contact ct = new Contact("Artur", 8937000000, "some@yandex.ru");
            string path = BinaryRW.SerializateObject(ct);
            Contact readContact = (Contact)BinaryRW.DeserializateObject(path);
            Console.WriteLine("Имя: " + readContact.Name);
            Console.WriteLine("Почта: " + readContact.Email);
            Console.WriteLine("Телефон: " + readContact.PhoneNumber);
        }
    }
}

