using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3___Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^\d]+)([\d]+)";
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (Match m in Regex.Matches(input,pattern))
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqueChars = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(result.ToString());
        }
    }
}
