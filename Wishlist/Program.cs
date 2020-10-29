using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Wishlist
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name three things you would like to recieve as a present.");
            string UserInput = Console.ReadLine().ToLower();
            string filePath = @"C:\Users\opilane\Data\wishlist.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();



            dataFromFile.Add(UserInput);
            File.WriteAllLines(filePath, dataFromFile);

        }
    }
}
