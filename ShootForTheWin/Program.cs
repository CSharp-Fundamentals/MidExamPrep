using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = "";

            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {

                int index = int.Parse(command);

                if (index >= 0 && index < numbers.Length)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int temp = numbers[index];

                        if (numbers[i] != -1 && i != index)
                        {
                            if (numbers[i] > temp)
                            {
                                numbers[i] -= temp;
                            }
                            else if (numbers[i] <= temp)
                            {
                                numbers[i] += temp;

                            }
                        }
                    }
                    numbers[index] = -1;
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', numbers));
        }
    }
}