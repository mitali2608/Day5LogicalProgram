using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class CouponNumber
    {
        public static void GetCoupon()
        {
            
            Console.WriteLine("Enter the number of coupons to be generated");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int num1;
            int coupon;
            
            for (int i = 1; i <= n; i++)
            {
                num1 = random.Next(124, 3176);
                coupon = (2372 * num1) % 100000;
                Console.WriteLine("coupon {0}-[{1}]", i, coupon);
            }

        }
    }
}

