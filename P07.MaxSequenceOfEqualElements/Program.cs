using System;
using System.Linq;

namespace P07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[i+1])
                {
                    n++;
                }
            }
        }
    }
}
