using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceEggs = priceFlour * 0.75;
            double priceMilk = (priceFlour * 1.25) / 4;
            int cozonacs = 0;
            int coloredEggs = 0;
            double oneCozonac = priceFlour + priceEggs + priceMilk;

            while (true)
            {
                budget -= oneCozonac;

                if (budget < 0)
                {
                    budget += oneCozonac;
                    break;
                }

                cozonacs++;
                coloredEggs += 3;

                if (cozonacs % 3 == 0)
                {
                    coloredEggs -= cozonacs - 2;
                }
            }
            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:F2}BGN left.");

        }
    }
}
