using System;

namespace _1._Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
              
                decimal totalLength = decimal.Parse( Console.ReadLine());
                decimal totalWidth = decimal.Parse( Console.ReadLine());
                decimal wingLength = decimal.Parse( Console.ReadLine());
                var totalYears = (totalLength * totalLength) * (totalWidth + 2 * wingLength);
                Console.WriteLine(totalYears);
            }
        }
    }
}
