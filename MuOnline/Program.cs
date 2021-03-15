using System;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string[] tokens = array[i].Split();

                string command = tokens[0];
                int amount = int.Parse(tokens[1]);

                if (command == "potion")
                {
                    health += amount;
                    if (health > 100)
                    {
                        int healed = health - 100;
                        int blood = amount - healed;
                        Console.WriteLine($"You healed for {blood} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (command == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    health -= amount;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
