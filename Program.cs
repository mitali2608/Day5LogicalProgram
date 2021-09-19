using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            FibonacciSeries.GetfibonacciSeries();
            PerfectNumber.GetPerfectnumber();
            PrimeNumber.GetPrime();
            ReverseNumber.GetReverse();
            CouponNumber.GetCoupon();
            Console.ReadKey();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time Elapsed = " + time + "ms");
        }
    }
}
