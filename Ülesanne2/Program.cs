using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\Test";
            string userStars = "stars";
            string userPlanets = "planets";
            string fullStarsPath = $@"{rootDirectory}\{userStars}.txt";
            string fullPlanetsPath = $@"{rootDirectory}\{userPlanets}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileStarsExists = File.Exists(fullStarsPath);
            bool filePlanetsExists = File.Exists(fullPlanetsPath);

            if(directoryExists && fileStarsExists && filePlanetsExists)
            {
                Console.WriteLine($"{userStars} and {userPlanets} already exists in {rootDirectory}");
            }
            else
            {
                Console.WriteLine($"{rootDirectory} does not exists");
                Console.WriteLine($"{rootDirectory} has been created");
                File.Create(fullStarsPath);
                File.Create(fullPlanetsPath);
                Console.WriteLine($"{userStars}.txt and {userPlanets} have been created in {rootDirectory}");
            }
        }
    }
}
