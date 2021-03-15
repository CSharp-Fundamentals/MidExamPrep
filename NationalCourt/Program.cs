using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            int all = first + second + third;
            int hours = 0;

            while (true)
            {
                if (people>0)
                {
                    people -= all;
                    hours++;
                }
                else
                {
                    break;
                }
                if (hours%4==0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
