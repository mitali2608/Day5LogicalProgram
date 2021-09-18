using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class FibonacciSeries
    {
        public static void GetfibonacciSeries()
        {
            Console.WriteLine("Enter the value till fibonacci series needs to be generated");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int i = 2;

            while (i < num)
            {
                i = i + 1;
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}

