using System;
using System.Formats.Asn1;

namespace Module4Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🦁 Welcome to Como Park Zoo! 🐘");
            Console.WriteLine("================================");

            // First, let's see a simple array example
            Console.WriteLine("Here are some animals we already have:");
            string[] sampleAnimals = { "Sea Lion", "Giraffe", "Lemur", "Polar Bear" };

            for (int i = 0; i < sampleAnimals.Length; i++)
            {
                Console.WriteLine($"- {sampleAnimals[i]}");
            }

            Console.WriteLine("\nNow let's add your animals to the Como Zoo!\n");

            // Use a while loop to get valid input
            Console.Write("How many animals do you want to add? ");
            int numberOfAnimals;
            while (!int.TryParse(Console.ReadLine(), out numberOfAnimals) || numberOfAnimals <= 0)
            {
                Console.Write("Please enter a number greater than 0: ");
            }

            // Create an array to store animal names
            string[] animals = new string[numberOfAnimals];

            // Use a for loop to collect animal names
            for (int i = 0; i < numberOfAnimals; i++)
            {
                Console.Write($"Enter animal #{i + 1}: ");
                animals[i] = Console.ReadLine();
            }

            // Display all animals using another for loop
            Console.WriteLine("\nYour new Como Zoo animals:");
            Console.WriteLine("-----------------");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i]}");
            }

            Console.WriteLine($"\nYou added {animals.Length} animals in to Como zoo!");

        }
    }
}