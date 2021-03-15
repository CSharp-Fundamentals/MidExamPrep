using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] data = input.Split(" - ");
                string command = data[0];

                switch (command)
                {
                    case "Collect":
                        if (!items.Contains(data[1]))
                        {
                            items.Add(data[1]);
                        }
                        break;
                    case "Drop":
                        if (items.Contains(data[1]))
                        {
                            items.Remove(data[1]);
                        }
                        break;
                    case "Combine Items":
                        string[] currentItems = data[1].Split(':');
                        if (items.Contains(currentItems[0]))
                        {
                            int indexOfOld = items.IndexOf(currentItems[0]);
                            items.Insert(indexOfOld + 1, currentItems[1]);
                        }
                        break;
                    case "Renew":
                        string item = data[1];
                        if (items.Contains(item))
                        {
                            int index = items.IndexOf(item);
                            items.RemoveAt(index);
                            items.Add(item);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));

        }

    }
}