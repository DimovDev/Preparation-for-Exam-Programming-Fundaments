using System;

namespace Problem_1._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long power = long.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;
            long currentpower = power;
            while (currentpower >= distance)
            {
                currentpower -= distance;
                count++;

                if (currentpower == power / 2 && power % 2 == 0 && exhaustionFactor != 0)
                {
                    currentpower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currentpower);
            Console.WriteLine(count);
        }
    }
}
