using System;
using System.Linq;

namespace P03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++) 
            {
                if (i % 2 == 0)
                {
                    int[] inputLines = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    array1[i] = inputLines[0];
                    array2[i] = inputLines[1];
                }
                else 
                {
                    int[] inputLines = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    array1[i] = inputLines[1];
                    array2[i] = inputLines[0];
                }
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
