using System;
using System.Linq;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            int[] jArray = new int[input.Length];
            int[] iArray = new int[input.Length];

            int written = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //Проверка i
                for (int iCheck = written; iCheck > 0; iCheck--)
                {
                    if (input[i] == iArray[iCheck])
                    {
                        break;
                    }
                //Край проверка i
                    else
                    {
                        for (int j = 0; j < input.Length; j++)
                        {
                            //Проверка J
                            for (int jCheck = written; jCheck > 0; jCheck--)
                            {
                                if (input[j] == jArray[jCheck])
                                {
                                    break;
                                }
                            //Kрай на проверката
                                else
                                {
                                    if (input[i] + input[j] == sum)
                                    {
                                        Console.WriteLine($"{input[i]} {input[j]}");
                                        iArray[written] = input[i]; jArray[written] = input[j];
                                        written++;
                                    }
                                }
                            }
                        }
                    }
                    //Проверката може да е отзад напред да започва от written защото 0 при jArray остава празно!!!
                }
                
            }
        }
    }
}
