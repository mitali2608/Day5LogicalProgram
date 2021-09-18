using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class ReverseNumber
    {
		public static void GetReverse()
		{
			int num;
			int reverse = 0;

			Console.WriteLine("Enter the number : ");
			num = int.Parse(Console.ReadLine());

			while (num > 0)
			{
				reverse = reverse * 10 + num % 10;
				num = num / 10;
			}

			Console.WriteLine("Reversed number : {0}", reverse);

		}
	}
}
