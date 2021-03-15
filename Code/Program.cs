using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryIndex = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int leftSum = 0;
            int rightSum = 0;


            for (int i = 0; i < entryIndex; i++)
            {
                if (type == "cheap")
                {
                    if (items[i] < items[entryIndex])
                    {
                        leftSum += items[i];
                    }
                }
                else
                {
                    if (items[i] >= items[entryIndex])
                    {
                        leftSum += items[i];
                    }
                }
            }
            for (int i = entryIndex; i < items.Length; i++)
            {
                if (type == "cheap")
                {
                    if (items[i] < items[entryIndex])
                    {
                        rightSum += items[i];
                    }
                }
                else
                {
                    if (items[i] >= items[entryIndex])
                    {
                        rightSum += items[i];
                    }
                }
            }
            if (leftSum>=rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
