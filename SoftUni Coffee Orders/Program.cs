using System;

namespace SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrise = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePercapsule = decimal.Parse(Console.ReadLine());
                string datestr = Console.ReadLine();
                decimal capsulesCount = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(datestr, "d/M/yyyy", null);
                decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal price = (daysInMonth * capsulesCount) * pricePercapsule;
                totalPrise += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrise:f2}");

        }
    }
}
