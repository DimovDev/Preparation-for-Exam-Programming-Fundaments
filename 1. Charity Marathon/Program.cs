using System;

namespace _1._Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dayMarathon = decimal.Parse(Console.ReadLine());
            decimal runners = decimal.Parse(Console.ReadLine());
            decimal laps = decimal.Parse(Console.ReadLine());
            decimal lengthOfTrack=decimal.Parse(Console.ReadLine());
            decimal capacityOfTrack = decimal.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());
            if (runners>capacityOfTrack*dayMarathon)
            {
                runners = capacityOfTrack*dayMarathon;
            }
            decimal moneyraised =( (runners * laps * lengthOfTrack) / 1000 )* moneyPerKm;
            Console.WriteLine($"Money raised: {moneyraised:f2}");

        }
    }
}
