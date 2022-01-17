using System;

namespace ProgrammingProblems_Set_2
{
    internal class Program
    {
 
        public static void Main(string[] args)
        {

            ChooseProblem();

        }
        
        private static void ChooseProblem()
        {
            Console.WriteLine("Choose one problem:");

            var optionChosen = -1;
            while (optionChosen != 0)
            {
                optionChosen = GetUserInput();

                switch (optionChosen) 
                {
                    case -1:
                        Console.WriteLine("Wrong input. Try again...");
                        break;
                    case 1:
                        exercise_1.CountEvenNumbers();
                        break;
                    case 2:
                        exercise_2.CountNumberTypes();
                        break;
                    case 3:
                        exercise_3.SumAndProduct();
                        break;
                    case 4:
                        exercise_4.FindPosition();
                        break;
                    case 5:
                        exercise_5.ValueEqualsPosition();
                        break;
                    case 6:
                        exercise_6.IsOrdered();
                        break;
                    case 7:
                        exercise_7.MinAndMax();
                        break;
                    case 8:
                        exercise_8.NthFibonacci();
                        break;
                    case 9:
                        exercise_9.IsNumberSequenceMonotone();
                        break;
                    case 10:
                        exercise_10.PrintConsecutiveEqualNumbers();
                        break;
                    case 11:
                        exercise_11.TotalSumOfTheInputInverses();
                        break;
                    case 12:
                        exercise_12.PrintConsecutiveNumberGroups();
                        break;
                    case 13:
                        exercise_13.IsNumberSequenceSequentiallyIncreasingAndRounded();
                        break;
                    default:
                        Console.WriteLine("\nYou should choose a valid option...");
                        break;
                }
            }
        }
        
        private static int GetUserInput()
        {
            PromptTheUser();
            var userInput = Console.ReadLine();
            return ValidateInput(userInput);
        }

        private static int ValidateInput(string input)
        {
            if (int.TryParse(input, out var optionChosen))
            {
                return optionChosen;
            }

            MessageUtils.AskingNumbersWithCountOf(1);
            return -1;
        }

        private static void PromptTheUser()
        {
            Console.WriteLine("<------------------------------------------------------------------------->");
            Console.Write("\n\n" +
                          "Choose a problem from 1 to 17" +
                          "Press 0 to quit!\n\n");
        }
        
    }
}