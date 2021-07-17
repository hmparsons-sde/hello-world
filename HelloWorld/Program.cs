﻿
using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Howdy Y'all!!");
            Console.WriteLine("Please type your name");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Please type your favorite color");

            var favoriteColor = Console.ReadLine();


            var animals = new String[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                {
                    if (animal.Length > 5)
                    {
                        Console.WriteLine(animal);
                    }
                }
            }

            Random rand = new Random();
            int index = rand.Next(animals.Length);
            Console.WriteLine($"Would you like to have a {favoriteColor} {animals[index]}?");
            Console.WriteLine("Pick your poison:");
            for (var i = 0; i < args.Length; i++)
            {
                Console.Write(args[i] + Environment.NewLine);
            }
            var userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "southern":
                    Console.WriteLine("Howdy Y'all!");
                    break;
                case "meh":
                    Console.WriteLine("hey");
                    break;
                case "texas":
                    Console.WriteLine("murrica! don't take mah guns!");
                    break;
                default:
                    Console.WriteLine("Howdy, Y'all!");
                    break;
            }
        }
    }
}