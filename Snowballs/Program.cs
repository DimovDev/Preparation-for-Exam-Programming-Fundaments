using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = -999999999999999;
            int snow = 0;
            int Time = 0;
            int Quality = 0;
            for (int i = 0; i < n; i++)
            {
               int  snowballSnow = int.Parse(Console.ReadLine());
               int  snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                BigInteger snowballValue1 = (BigInteger)(snowballValue);
               // snowballValue = maxValue;
                if (snowballValue1> maxValue)
                {
                    maxValue = snowballValue1;
                    snow = snowballSnow;
                    Time = snowballTime;
                    Quality = snowballQuality;
                }
            }

            Console.WriteLine($"{snow} : {Time} = {maxValue} ({Quality})");

        }
    }
}
