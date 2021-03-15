using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int currentIndex = 0;

            while (command!="Love!")
            {
                string[] token = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string jump = token[0];
                int places = int.Parse(token[1]);

                currentIndex += places;

                if (currentIndex>=houses.Length)
                {
                    currentIndex = 0;
                }

                if (houses[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    houses[currentIndex] -= 2;
                    if (houses[currentIndex]==0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");

            int counter = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i]!=0)
                {
                    counter++;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
