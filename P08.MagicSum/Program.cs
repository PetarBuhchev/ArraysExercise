using System;
using System.Linq;

namespace P08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;

            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] == first || input[i] == second)
                {
                    continue;
                }
                for (int j = 0; j < input.Length; j++) 
                {
                    if (input[j] == second || input[j] == first) 
                    {
                        continue;
                    }
                    if (input[i] + input[j] == sum)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                        j += input.Length;
                        first = i;
                        second = j;
                    }
                }
            }
        }
    }
}
