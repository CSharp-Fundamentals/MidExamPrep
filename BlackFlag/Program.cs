using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;
            double thirdDayPlunder = dailyPlunder*0.5;


            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;

                if (i%3==0)
                {
                    totalPlunder += thirdDayPlunder;
                }
                if (i%5==0)
                {
                    totalPlunder -= totalPlunder * 0.3;
                }
            }
            if (totalPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else
            {
                double left = expectedPlunder - totalPlunder;
                double percentage = (expectedPlunder/left)*100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
