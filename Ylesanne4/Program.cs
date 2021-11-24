using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirectory = @"C:\Users\opilane\samples\Test";
            Console.WriteLine("What file would you like displayed");
            string userFile = Console.ReadLine();
            string fileDirec = $@"{rootdirectory}\{userFile}";
            bool exists = File.Exists(fileDirec);
            if (exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirec);
                if (userFile == "planets" || userFile == "stars")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt file does not exists");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt file does not exists");
            }
        }
    }
}
