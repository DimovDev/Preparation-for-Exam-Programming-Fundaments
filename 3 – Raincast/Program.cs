using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3___Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePattern = "^Type: (Normal|Warning|Danger)$";
            string sourcePattern = "^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = "^Forecast: ([^!.,?]+)$";
            List<string> raincast = new List<string>();
            string inputLine = "";
            string currentLine = "type";
            string currentRainCast = "";
            while ((inputLine=Console.ReadLine())!= "Davai Emo" )
            {
                switch (currentLine)
                {
                    case"type":
                        if (Regex.IsMatch(inputLine,typePattern))
                        {
                          currentRainCast=$"({ Regex.Match(inputLine, typePattern).Groups[1]})";
                            currentLine = "source";
                        }
                        break;
                    case "source":
                        if (Regex.IsMatch(inputLine,sourcePattern))
                        {
                            currentRainCast+=" " + "***" + " ~ " + $"{ Regex.Match(inputLine, sourcePattern).Groups[1]}";
                            currentLine = "forecast";
                        }
                        break;
                    case "forecast":
                       
                        if (Regex.IsMatch(inputLine, forecastPattern))
                        {
                           
                            currentRainCast = currentRainCast.Replace("***",
                                Regex.Match(inputLine, forecastPattern).Groups[1].Value);
                            raincast.Add(currentRainCast);
                            currentLine = "type";
                        }

                        break;
                }
            }
            foreach (var rain in raincast)
            {
                Console.WriteLine(rain);
            }
        }
    }
}
