using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0]=="END")
                {
                    break;
                }
                else if (input[0]=="Change")
                {
                    int paintingNumber = int.Parse(input[1]);
                    int changedNumber = int.Parse(input[2]);

                    if (numbers.Contains(paintingNumber))
                    {
                        int firstIndex = numbers.IndexOf(paintingNumber);
                        int secondIndex = numbers.IndexOf(changedNumber);

                        firstIndex = secondIndex;
                    }
                }
                else if (input[0]=="Hide")
                {
                    int paintingNumber = int.Parse(input[1]);

                    if (numbers.Contains(paintingNumber))
                    {
                        numbers.Remove(paintingNumber);
                    }
                }
                else if (input[0]=="Switch")
                {
                    int firstPaintingNumber = int.Parse(input[1]);
                    int secondPaintingNumber = int.Parse(input[2]);

                    if (numbers.Contains(firstPaintingNumber) && numbers.Contains(secondPaintingNumber))
                    {
                        int firstIndex = numbers.IndexOf(firstPaintingNumber);
                        int secondIndex = numbers.IndexOf(secondPaintingNumber);

                        int temp = firstIndex;
                        firstIndex = secondIndex;
                        secondIndex = temp;
                    }
                }
                else if (input[0]=="Insert")
                {
                    int place = int.Parse(input[1]);
                    int paintingNumber = int.Parse(input[2]);

                    if (place<numbers.Count)
                    {
                        numbers.Insert(place+1,paintingNumber);
                    }
                }
                else if (input[0]=="Reverse")
                {
                    numbers.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
