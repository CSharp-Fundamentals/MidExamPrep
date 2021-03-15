using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battles = 0;

            string input = Console.ReadLine();
            int number=0;
            bool TypeCheck = int.TryParse(input, out number);

            while (true)
            {
                if (TypeCheck)
                {
                    energy -= number;

                    if (energy >= 0)
                    {
                        battles++;
                    }
                    else
                    {
                        Console.WriteLine($"Not enough energy! Game ends with {battles} won battles and {energy + number} energy");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Won battles: {battles}. Energy left: {energy}");
                    break;
                }

                if (battles%3==0)
                {
                    energy += battles;
                }
                input = Console.ReadLine();
                number=0;
                TypeCheck = int.TryParse(input, out number);
            }
        }
    }
}
