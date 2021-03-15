using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamSecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split("|",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double budget = double.Parse(Console.ReadLine());
            double profit = 0;

            List<double> bought = new List<double>();

            for (int i = 0; i < items.Count; i++)
            {
                string[] commandInput = items[i].Split("->").ToArray();

                string product = commandInput[0];
                double price = double.Parse(commandInput[1]);

                if (product=="Clothes" && price<=50.00 && budget>price)
                {
                    profit += price * 0.4;
                    budget -= price;
                    price *= 1.4;
                    bought.Add(price);
                }
                else if (product == "Shoes" && price <= 35.00 && budget > price)
                {
                    profit += price * 0.4;
                    budget -= price;
                    price *= 1.4;
                    bought.Add(price);
                }
                else if (product == "Accessories" && price <= 20.50 && budget > price)
                {
                    profit += price * 0.4;
                    budget -= price;
                    price *= 1.4;
                    bought.Add(price);
                }
            }
            foreach (var value in bought)
            {
                Console.WriteLine($"{1}", value, Math.Round(value, 2,
                                             MidpointRounding.ToEven));
            }
        }
    }
}
