using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _4___RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<int>> custumer = new Dictionary<string, List<int>>();
            string input = string.Empty;
            while ((input=Console.ReadLine()) != "I believe I can fly!")
            {
                string [] token = input.Split(new char[] { ' ', '=' },StringSplitOptions.RemoveEmptyEntries);
                if (char.IsLetter(token[0][0]) && char.IsNumber(token[1][0]))
                {
                    string name = token[0];

                    if (!custumer.ContainsKey(name))
                    {
                        custumer[name] = new List<int>();
                    }
                    custumer[name].AddRange(token.Skip(1).Select(int.Parse));
                }
                else
                {
                    string originName = token[0];
                    string targetName = token[1];
                    custumer[originName] = new List<int>(custumer[targetName]);
                }
            }
            Dictionary<string, List<int>> sorted = custumer.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).
                ToDictionary(x => x.Key, x => x.Value);
            foreach (var custume in sorted)
            {
                Console.WriteLine($"#{custume.Key} ::: {string.Join(", ",custume.Value.OrderBy(x=>x))}");
            }
        }
    }
}
