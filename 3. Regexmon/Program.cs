using System;
using System.Text.RegularExpressions;

namespace _3._Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          string  didiPattern = @"[^A-Za-z-]+";
          string  bojoPattern = @"[A-Za-z]+-[A-Za-z]+";

            Regex regexDidi = new Regex(didiPattern);
            Regex regexBojo = new Regex(bojoPattern);

            while (true)
            {
                Match didiMatch = regexDidi.Match(input);
                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int firstSimbolDidi = didiMatch.Index;
                input = input.Substring(firstSimbolDidi + didiMatch.Length);
                Match bojoMatch = regexBojo.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());

                }
                else
                {
                    return;

                }
                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
            }
        }
    }
}
