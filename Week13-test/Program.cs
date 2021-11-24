using System;
using System.IO;

namespace Week13_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            Console.WriteLine("Enter directory name: ");
            string userDirectory = Console.ReadLine();

            string newDirectoryFullPath = $@"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} alredy exists in {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userDirectory} has been created.");
            }

        }
    }
}
