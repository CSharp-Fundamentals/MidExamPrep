using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < wagons.Length; i++)
            {
                while (wagons[i]!=4)
                {
                    wagons[i]++;
                    people--;

                    if (people<1)
                    {
                        break;
                    }
                }
            }
            if ((wagons[wagons.Length-1])<4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ",wagons));
            }
            else if ((wagons[wagons.Length - 1]) == 4 && people>0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
