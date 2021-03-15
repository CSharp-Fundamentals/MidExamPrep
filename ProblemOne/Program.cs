using System;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double coffeePrice = (daysInMonth * capsulesCount) * pricePerCapsule;
                total += coffeePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
