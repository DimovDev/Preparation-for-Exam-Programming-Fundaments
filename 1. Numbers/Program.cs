using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var average = nums.Average();
            nums.Sort();
            nums.Reverse();
           List<int> sorted = new List<int>();
           // if (nums.Count<=1)
            {
                Console.WriteLine("No");
            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]>average)
                {
                    sorted.Add(nums[i]);
                }
            

            }
           

            Console.WriteLine(string.Join(" ", sorted.Take(5)));

        }
    }
}
