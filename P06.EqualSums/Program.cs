using System;
using System.Linq;

namespace P06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSide = 0;
            int rightSide = 0;
            int need = 0;

            if (input.Length == 1) 
            {
                Console.WriteLine("0");
                //rightSide става 1 за да не отговаря на if-a най-долу
                rightSide = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0 || i == input.Length - 1)
                {
                    need++;
                    continue;
                }
                for (int j = 0; j < need; j++)
                {
                    leftSide += input[j];
                }
                for (int m = i+1; m < input.Length; m++)
                {
                    rightSide += input[m];
                }
                if (leftSide == rightSide) 
                {
                    Console.WriteLine(need);
                    break;
                }
                else
                {
                    need++;
                    rightSide = 0;
                    leftSide = 0;
                }
            }
            if (rightSide == 0 && leftSide == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
