using System;
using System.Linq;

namespace P04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] output = new int[input.Length];
            int num = input.Length;

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (j == 0)
                    {
                        output[output.Length - 1] = input[j];
                        continue;
                    }
                    output[j - 1] = input[j];
                }
                Array.Copy(output, input, output.Length);
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
