using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cubes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Mort")
            {
                string[] token = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = token[0];
                int value = int.Parse(token[1]);

                if (command=="Mort")
                {
                    break;
                }
                else if (command=="Add")
                {
                    cubes.Add(value);
                }
                else if (command=="Remove")
                {
                    cubes.Remove(value);
                }
                else if (command=="Replace")
                {
                    int replacement = int.Parse(token[2]);
                    int index = cubes.IndexOf(value);

                    if (cubes.Contains(value))
                    {
                        cubes.Insert(index, replacement);
                        cubes.Remove(value);
                    }
                }
                else
                {
                    for (int i = 0; i < cubes.Count; i++)
                    {
                        if (cubes[i] < value)
                        {
                            cubes.Remove(cubes[i]);
                            i--;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", cubes));
        }
    }
}
