using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (snowmen.Count != 1)
            {
                foreach (var item in snowmen)
                {
                    int index = snowmen[item];
                    int attacker = snowmen[index - item];
                    int target = snowmen[item];
                    int difference = Math.Abs(attacker - target);
                    NewMethod(snowmen, attacker, target, difference);
                }

            }

        }

        private static void NewMethod(List<int> snowmen, int attacker, int target, int difference)
        {
            if (difference % 2 == 0)
            {
                snowmen.Remove(target);
            }
            else
            {
                snowmen.Remove(attacker);
            }
        }
    }
}
