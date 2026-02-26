using System;
using System.IO;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\file.txt";
            string targetPath = @"d:\bkp\file.bkp";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines  = File.ReadAllLines(fileInfo.FullName);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An Error occurred");
                Console.WriteLine(e.Message);
            }
            
            
            





        }
    }
}