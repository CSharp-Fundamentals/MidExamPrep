using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0]=="end")
                {
                    break;
                }
                else if (command[0]=="swap")
                {
                    int temp = array[int.Parse(command[1])];
                    array[int.Parse(command[1])] = array[int.Parse(command[2])];
                    array[int.Parse(command[2])] = temp;
                }
                else if (command[0]=="multiply")
                {
                    array[int.Parse(command[1])] *= array[int.Parse(command[2])];
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
