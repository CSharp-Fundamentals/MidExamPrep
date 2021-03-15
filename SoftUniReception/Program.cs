using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstEmployeeEficiency = double.Parse(Console.ReadLine());
            double secondEmployeeEficiency = double.Parse(Console.ReadLine());
            double thirdEmployeeEficiency = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());

            double answerPerHour = firstEmployeeEficiency + secondEmployeeEficiency  + thirdEmployeeEficiency;
            int neededHours = 0;

            while (students > 0)
            {
                students -= answerPerHour;
                neededHours++;

                if (neededHours % 4 == 0)
                {
                    neededHours++;
                }
            }
            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
