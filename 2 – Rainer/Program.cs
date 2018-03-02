using System;
using System.Linq;

namespace _2___Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] initialRaindropStates = inputNumbers.Take(inputNumbers.Length - 1).ToArray();
            int[] currentRaindropStates = initialRaindropStates.ToArray();
            int curentIndex = inputNumbers.Last();
            bool hasGottenWet = false;
            int step = 0;
            while (!hasGottenWet)
            {
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    currentRaindropStates[i]--;
                }
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    if (currentRaindropStates[i]==0 && i==curentIndex)
                    {
                        hasGottenWet = true;
                        break;
                    }
                }
              if (hasGottenWet)
                {
                  break;

                }
                for (int i = 0; i < currentRaindropStates.Length; i++)
                {
                    if (currentRaindropStates[i]==0)
                    {
                        currentRaindropStates[i] = initialRaindropStates[i];
                    }
                }
                curentIndex = int.Parse(Console.ReadLine());
                step++;
            }
            Console.WriteLine(String.Join(" ",currentRaindropStates));
            Console.WriteLine(step);
        }
    }
}
