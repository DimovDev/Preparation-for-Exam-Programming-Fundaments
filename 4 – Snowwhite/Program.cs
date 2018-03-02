using System;
using System.Collections.Generic;
using System.Linq;

namespace _4___Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();
               
            string line;

            while( (line = Console.ReadLine()) != "Once upon a time") 
            {
                string[] tokens = line.Split(new [] {" <:> " },StringSplitOptions.RemoveEmptyEntries);
                string dwarfsName = tokens[0];
                string dwarfsHatColor = tokens[1];
                int dwarfsPhisics = int.Parse(tokens[2]);
                if (colors.ContainsKey(dwarfsHatColor)==false)
                {
                    colors.Add(dwarfsHatColor, 1);
                }
                else
                {
                    colors[dwarfsHatColor]++;
                }
                string currentDwarfId = $"{dwarfsName} <:>{dwarfsHatColor}";
                if (dwarfs.ContainsKey(currentDwarfId) == false)
                {
                    dwarfs.Add(currentDwarfId, dwarfsPhisics);
                }
                else
                {
                    int oldValue = dwarfs[currentDwarfId];
                    if (dwarfsPhisics>oldValue)
                    {
                        dwarfs[currentDwarfId] = dwarfsPhisics;
                    }
                }
            }
            Dictionary<string, int> sortedDwarfs = dwarfs.
                OrderByDescending(d => d.Value).
              ThenByDescending(d => colors[d.Key.Split(new [] { " <:> " }, StringSplitOptions.RemoveEmptyEntries)[1]]).
              ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var dwarf in sortedDwarfs)
            {
                string dwarfId = dwarf.Key;
                string [] dwarfIdTokens=dwarfId.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = dwarfIdTokens[0];
                string dwarfHatColor = dwarfIdTokens[1];
                int dwarfphisics = dwarf.Value;
                Console.WriteLine($"({dwarfHatColor}) {dwarfName} <-> {dwarfphisics}");
            }

        }
    }
}
