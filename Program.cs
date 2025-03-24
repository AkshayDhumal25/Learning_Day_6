//2.WAP for getting a square root of a given number.
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to get the SquareRoot : ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"SquareRoot of {n} is " + Math.Sqrt(n));
        }
    }
}