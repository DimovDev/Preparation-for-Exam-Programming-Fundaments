using System;
using System.Collections.Generic;

namespace _2___AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            List<string> partitions = new List<string>();
            string line;
            int startIndex;
            int endIndex;
            while ((line = Console.ReadLine()) != "3:1")
            {
                string[] input = line.Split();
                string command = input[0];
                switch (command)
                {
                    case "merge":
                        startIndex = int.Parse(input[1]);
                        endIndex = int.Parse(input[2]);
                        startIndex = ValidIndex(startIndex, text.Count);
                        endIndex = ValidIndex(endIndex, text.Count);

                        string merged = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            merged += text[i];
                        }
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            text.RemoveAt(startIndex);
                        }
                        text.Insert(startIndex, merged);
                        break;

                    case "divide":
                        startIndex = int.Parse(input[1]);
                        endIndex = int.Parse(input[2]);
                        string word = text[startIndex];

                        partitions = Parts(word, endIndex);
                        text.RemoveAt(startIndex);
                        text.InsertRange(startIndex, partitions);
                        break;
                }

            }

            Console.WriteLine(string.Join(" ", text));
        }
        private static int ValidIndex(int index, int length)
        {
            if (index > length - 1)
            {
                index = length - 1;
            }

            if (index < 0)
            {
                index = 0;
            }
            return index;
        }
        private static List<string> Parts(string word, int partitionsCount)
        {
            List<string> result = new List<string>();

            int partLenght = word.Length / partitionsCount;
            for (int i = 0; i < partitionsCount; i++)
            {
                if (i == partitionsCount - 1)
                {
                    result.Add(word.Substring(i * partLenght));
                }
                else
                {
                    result.Add(word.Substring(i * partLenght, partLenght));
                }
            }
            return result;
        }
    }
}
