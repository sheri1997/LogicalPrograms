using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Number from the below Menu");
            Console.WriteLine("1:Fibonacci Series\n2:Perfect Number\n3:Prime Number\n4:Reverse a Number\n5:Coupon Number\n6:Stopwatch Program");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;
                case 2:
                    PerfectNumber.Perfect();
                    break;
                case 3:
                    PrimeNumber.Prime();
                    break;
                case 4:
                    Reverse.reverse();
                    break;
                case 5:
                    CouponNumber.couponNumber();
                    break;
                case 6:
                    StopWatch.stopWatch();
                    break;
                default:
                    Console.WriteLine("Invalid Choice, Please Enter a Number between 1 to 6 only");
                    break;
            }
        }
    }
}
