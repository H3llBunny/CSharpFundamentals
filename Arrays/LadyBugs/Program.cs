using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] lBugInitialPositionIndex = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] ladyBugField = new int[fieldSize];

            for (int i = 0; i < ladyBugField.Length; i++) //setting '1' on initial bug positions
            {
                if (lBugInitialPositionIndex.Contains(i))
                {
                    ladyBugField[i] = 1;
                }

            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] rules = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialPosition = int.Parse(rules[0]);
                string direction = rules[1];
                int countOfMoves = int.Parse(rules[2]);
                int newPostition = 0;

                if(countOfMoves < 0)
                {
                    if(direction == "left")
                    {
                        direction = "right";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                    else if(direction == "right")
                    {
                        direction = "left";
                        countOfMoves = Math.Abs(countOfMoves);
                    }
                }
                //check if the initial position is out of array or if it has NO bugs
                if(initialPosition < 0 || initialPosition > ladyBugField.Length - 1 || ladyBugField[initialPosition] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if(countOfMoves == 0 && initialPosition >= 0 && initialPosition <= ladyBugField.Length - 1)
                {
                    if (ladyBugField[initialPosition] == 1)
                    {
                        ladyBugField[initialPosition] = 0;
                    }
                }

                switch (direction)
                {
                    case "right":
                        newPostition = initialPosition + countOfMoves; // find new positon index
                        ladyBugField[initialPosition] = 0; //in both cases the initial index gets '0'

                        if(newPostition > ladyBugField.Length - 1) //check if new positin index is out of array
                        {
                            ladyBugField[initialPosition] = 0; //if it's out, current position gets '0' - LB flies out of the array
                            break;
                        }
                        else
                        {
                            for (int i = newPostition; i < ladyBugField.Length; i += countOfMoves) //array goes till LB fiends a free index or goes out of the array
                            {
                                if (ladyBugField[i] == 0)
                                {
                                    ladyBugField[i] = 1;
                                    break;
                                }
                            }
                        }
                        break;

                    case "left":
                        newPostition = initialPosition - countOfMoves;
                        ladyBugField[initialPosition] = 0; //in both cases the initial index gets '0'

                        if(newPostition < 0) //if new position is out of array, initial index of LB gets '0'
                        {
                            ladyBugField[initialPosition] = 0;
                            break;
                        }
                        else
                        {
                            for (int i = newPostition; i >= 0; i -= countOfMoves) //find free index or LB gets out of the array
                            {
                                if (ladyBugField[i] == 0) //if index if free LB lands on it
                                {
                                    ladyBugField[i] = 1;
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
