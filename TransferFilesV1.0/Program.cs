using System;
using System.IO;

namespace TransferFilesV1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Elad");
            Console.WriteLine("Please enter your Starting path");
            string path = Console.ReadLine();
            Console.WriteLine("Please enter your Ending path");
            string path2 = Console.ReadLine();
            //string mypath = @"C:\Users\Elad Ezra\Desktop\newWay\2020\C#\TestFolder";
            //string mypath2 = @"C:\Users\Elad Ezra\Desktop\My Folder\TestFolder";
            //MoveFile(mypath, mypath2);
            try
            {
                Directory.Move(path, path2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void MoveFile(string sourceName, string destName)
        {
            try
            {
                File.Move(sourceName, destName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (File.Exists(destName))
                Console.WriteLine("The file transfered succsessfully =]");
            else Console.WriteLine("The file didnt moved");
        }
    }
}
