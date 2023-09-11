using System;
using System.Linq;

namespace P05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool lower = true;

            for (int i = 0; i < input.Length; i++)
            {
                lower = true;
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        lower = false;
                    }                  
                }
                if (lower == true) 
                {
                    Console.Write($"{input[i]} ");
                }
            }
        }
    }
}
