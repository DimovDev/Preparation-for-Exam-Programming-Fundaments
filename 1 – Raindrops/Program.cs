using System;

namespace _1___Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int regions = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal coefficients = 0;
            decimal currentsum = 0;
            for (int i = 0; i < regions; i++)
            {
                var  input = Console.ReadLine().Split(new [] {' '});
                decimal raindropsCount= decimal.Parse( input[0]);
                decimal squareMeters = decimal.Parse( input[1]);
                currentsum = raindropsCount / squareMeters;
                sum += currentsum;
            }
            if (density != 0)
            {
                coefficients = sum / density;
                Console.WriteLine($"{coefficients:f3}");
            }
            else
            {
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
