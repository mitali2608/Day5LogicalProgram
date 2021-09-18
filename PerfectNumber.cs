using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class PerfectNumber
    {
        public static void GetPerfectnumber()
        {
            int sum = 0;
            Console.WriteLine("Enter a random value to check whether it is Perfect number or not- ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n == sum)
            {
                Console.WriteLine($"{n} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{n} is not a perfect number");
            }
        }
    }
}