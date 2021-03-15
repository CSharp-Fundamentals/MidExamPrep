using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            int numberOfMoves = 0;

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                numberOfMoves++;

                string[] tokens = command.Split();
                int firstIndex = int.Parse(tokens[0]);
                int secondIndex = int.Parse(tokens[1]);



                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < numbers.Count && secondIndex < numbers.Count && firstIndex != secondIndex)
                {
                    if (numbers[firstIndex] == numbers[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[firstIndex]}!");

                        if (firstIndex > secondIndex)
                        {
                            numbers.RemoveAt(firstIndex);
                            numbers.RemoveAt(secondIndex);
                        }
                        else
                        {
                            numbers.RemoveAt(secondIndex);
                            numbers.RemoveAt(firstIndex);
                        }

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (numbers[firstIndex] != numbers[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    numbers.Insert(numbers.Count / 2, $"-{numberOfMoves}a");
                    numbers.Insert(numbers.Count / 2, $"-{numberOfMoves}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }



                //Console.WriteLine(String.Join(" ", input));
                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", numbers));

        }

    }
}