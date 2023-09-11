using System;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++) 
            {
                int numPeople = int.Parse(Console.ReadLine());
                people[i] = numPeople;
                sum += numPeople;
            }
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
