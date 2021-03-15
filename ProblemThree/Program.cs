using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int entryIndex = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            List<int> leftPart = new List<int>();
            List<int> rightPart = new List<int>();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < items[entryIndex] - 1; i++)
            {
                leftPart.Add(items[i]);
            }
            for (int i = items[entryIndex]; i < items.Count; i++)
            {
                rightPart.Add(items[i]);
            }

            Console.WriteLine(string.Join(" ",leftPart));
            Console.WriteLine(string.Join(" ",leftPart));
        }
    }
}
