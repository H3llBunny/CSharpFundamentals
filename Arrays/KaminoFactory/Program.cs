using System;
using System.Linq;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] bestSample = new int[dnaLength];
            int leftmostIndex = dnaLength;
            int bestSampleSequenceLength = 0;
            int bestSampleSum = 0;
            int bestSampleNumber = 1;

            string command = Console.ReadLine();
            int sampleNum = 0;

            while(command != "Clone them!")
            {
                int[] currentSample = command.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                sampleNum++;

                int currentSequenceLength = 0;
                int previouseSequenceLength = 0;
                int currentLongestSequence = 0;

                int leftmostIndexInCurrentArray = dnaLength;

                int currentSampleSum = 0;

                for (int i = 0; i < currentSample.Length; i++)
                {

                    if (currentSample[i] == 1)
                    {
                        currentSequenceLength++;
                        currentSampleSum++;
                    }
                    else
                    {
                        previouseSequenceLength = currentSequenceLength;
                        currentSequenceLength = 0;
                    }

                    if(currentSequenceLength > previouseSequenceLength)
                    {
                        currentLongestSequence = currentSequenceLength;
                        leftmostIndexInCurrentArray = i - currentSequenceLength + 1;
                    }
                }

                if (currentLongestSequence > bestSampleSequenceLength)
                {
                    bestSampleSequenceLength = currentLongestSequence;
                    leftmostIndex = leftmostIndexInCurrentArray;
                    bestSample = currentSample;
                    bestSampleNumber = sampleNum;
                    bestSampleSum = currentSampleSum;
                }

                else if (currentLongestSequence == bestSampleSequenceLength)
                {
                    if (leftmostIndexInCurrentArray < leftmostIndex)
                    {
                        leftmostIndex = leftmostIndexInCurrentArray;
                        bestSampleSum = currentSampleSum;
                        bestSample = currentSample;
                        bestSampleNumber = sampleNum;
                    }

                    else if(leftmostIndex == leftmostIndexInCurrentArray)
                    {
                        if (currentSampleSum > bestSampleSum)
                        {
                            bestSampleSum = currentSampleSum;
                            bestSample = currentSample;
                            bestSampleNumber = sampleNum;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSampleSum}.");
            Console.WriteLine(string.Join(" ", bestSample));

        }
    }
}
