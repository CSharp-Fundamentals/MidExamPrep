using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                                                           .Split("!")
                                                           .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] item = command.Split(" ");
                string word = item[0];
                string product = item[1];
                switch (word)
                {
                    case "Urgent":


                        if (!shoppingList.Contains(product))
                        {
                            shoppingList.Insert(0, product);
                        }
                        break;

                    case "Unnecessary":
                        if (shoppingList.Contains(product))
                        {
                            shoppingList.Remove(product);
                        }
                        break;

                    case "Correct":
                        string newProduct = item[2];
                        int index = shoppingList.IndexOf(product);

                        if (shoppingList.Contains(product))
                        {
                            shoppingList.Insert(index, newProduct);
                            shoppingList.Remove(product);
                        }
                        break;

                    case "Rearrange":

                        if (shoppingList.Contains(product))
                        {
                            shoppingList.Remove(product);
                            shoppingList.Add(product);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}