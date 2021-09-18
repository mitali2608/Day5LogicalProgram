using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class PrimeNumber
    {
        public static void GetPrime()
        {
            int num, i, abc = 0;

            Console.Write("\n\n");
            Console.WriteLine("Check whether a given number is prime or not\n");
            Console.Write("\n\n");

            Console.WriteLine("Enter a number- ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    abc++;
                    break;
                }
            }
            if (abc == 0 && num != 1)

                Console.Write("{0} is a prime number.\n", num);
            else
                Console.Write("{0} is not a prime number\n", num);
        }
    }
    }

