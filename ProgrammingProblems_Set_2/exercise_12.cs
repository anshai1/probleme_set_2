using System;

namespace ProgrammingProblems_Set_2
{
    public class exercise_12
    {
        public static void PrintConsecutiveNumberGroups()
        {
            Console.WriteLine("Enter the amount of number you want to introduce:");
            var inputCount = Console.ReadLine();

            if (int.TryParse(inputCount, out var count))
            {
                var countOfConsecutiveGroups = 0;
                var consecutiveNumber = 1;

                Console.WriteLine("Enter a number:");
                var firstInput = Console.ReadLine();

                if (int.TryParse(firstInput, out var firstNumber))
                {
                    for (int i = 1; i < count; i++)
                    {
                        Console.WriteLine("Enter a number:");
                        var followingInput = Console.ReadLine();

                        if (int.TryParse(followingInput, out var followingNumber))
                        {
                            if (firstNumber != 0 && followingNumber != 0 && firstNumber + 1 == followingNumber)
                            {
                                consecutiveNumber++;
                            }
                            else
                            {
                                if (consecutiveNumber > 1)
                                {
                                    countOfConsecutiveGroups++;
                                    consecutiveNumber = 1;
                                }
                            }
                        }

                        firstNumber = followingNumber;
                    }
                }

                Console.WriteLine($"\nNumber of consecutive groups is: {countOfConsecutiveGroups}");
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }
    }
}