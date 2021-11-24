using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string newPath = @"C:\Users\opilane\samples\";
            Console.WriteLine("Enter your file name: ");
            string kasutajakaust = Console.ReadLine();

            string newdirectory = $@"{newPath}\{kasutajakaust}";


            bool directoryExists = Directory.Exists(newdirectory);

            if (directoryExists)
            {
                Console.WriteLine($"{kasutajakaust} already exists in samples");
            }
            else
            {

                Directory.CreateDirectory(newdirectory);
                Console.WriteLine($"directory {kasutajakaust} has been created");
            }
            Console.ReadLine();
        }
    }
}
