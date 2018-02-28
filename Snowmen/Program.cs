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
               int attacker = snowmen.Last();
                int target = snowmen[0];
                int difference = Math.Abs(attacker - target);
                if (difference %2 ==0)
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
}
