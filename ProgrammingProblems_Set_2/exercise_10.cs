using System;

namespace ProgrammingProblems_Set_2
{
    public class exercise_10
    {

        public static void PrintConsecutiveEqualNumbers()
        {
            Console.WriteLine("Enter the amount of number you want to introduce:");
            var inputCount = Console.ReadLine();
            if (int.TryParse(inputCount, out var count))
            {
                Console.WriteLine("Enter a number:");
                var firstInput = Console.ReadLine();
                Console.WriteLine("Enter a number:");
                var secondInput = Console.ReadLine();

                var countOfConsecutiveEquals = 1;
                var maxOfConsecutiveEquals = 0;

                if (int.TryParse(firstInput, out var firstNumber) && int.TryParse(secondInput, out var followingNumber))
                {
                    if (firstNumber == followingNumber)
                        countOfConsecutiveEquals++;
                    for (var i = 2; i < count; i++)
                    {
                        Console.WriteLine("Enter a number:");
                        var input = Console.ReadLine();
                        if (int.TryParse(input, out var number))
                        {
                            if (followingNumber == number)
                            {
                                countOfConsecutiveEquals++;
                            }
                            else if(maxOfConsecutiveEquals != countOfConsecutiveEquals && maxOfConsecutiveEquals < countOfConsecutiveEquals)
                            {
                                maxOfConsecutiveEquals = countOfConsecutiveEquals;
                                countOfConsecutiveEquals = 1;
                            }
                            else
                            {
                                countOfConsecutiveEquals = 1;
                            }
                        }

                        followingNumber = number;
                    }
                }

                if (maxOfConsecutiveEquals < countOfConsecutiveEquals)
                    maxOfConsecutiveEquals = countOfConsecutiveEquals;

                Console.WriteLine($"Max of consecutive equal numbers is: {maxOfConsecutiveEquals}");
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }
        
    }
}