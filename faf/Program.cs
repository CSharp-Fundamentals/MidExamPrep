using System;
using System.Collections.Generic;
using System.Linq;

namespace faf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                           .Split("|", StringSplitOptions.RemoveEmptyEntries)
                           .ToList();

            double budget = double.Parse(Console.ReadLine());
            double profit = 0;

            List<double> bought = new List<double>();

            for (int i = 0; i < items.Count; i++)
            {
                string[] commandInput = items[i].Split("->").ToArray();

                string product = commandInput[0];
                double price = double.Parse(commandInput[1]);

                if (product == "Clothes" && price <= 50.00 && budget >= price)
                {
                    profit += price * 0.4;
                    budget -= price;
                    price *= 1.4;
                    bought.Add(price);
                }
                else if (product == "Shoes" && price <= 35.00 && budget >= price)
                {
                    profit += price * 0.4;
                    budget -= price;
                    price *= 1.4;
                    bought.Add(price);
                }
                else if (product == "Accessories" && price <= 20.50 && budget >= price)
                {
                    profit += price * 0.4;
                    budget -= price;
                    price *= 1.4;
                    bought.Add(price);
                }
            }
            if ((bought.Sum() + profit) >= 150)
            {
                foreach (var value in bought)
                {
                    Console.Write($"{value:F2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:F2}");
                Console.WriteLine("Hello, France!");
            }
            else
            {
                foreach (var value in bought)
                {
                    Console.Write($"{value:F2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:F2}");
                Console.WriteLine("Time to go.");
            }
            
        }
    }
}
