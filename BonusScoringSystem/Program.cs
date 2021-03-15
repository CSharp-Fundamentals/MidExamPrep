using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());

            double maxBonus = 0;
            double studentAttendances = 0;
            double sum = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double attendances = double.Parse(Console.ReadLine());

                sum = (attendances / lecturesCount) * (5 + additionalBonus);

                if (sum>maxBonus)
                {
                    maxBonus = sum;
                    studentAttendances = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}
