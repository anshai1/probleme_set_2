using System;

namespace ProgrammingProblems_Set_2
{
    public class exercise_13
    {
        public static void IsNumberSequenceSequentiallyIncreasingAndRounded()
        {
            Console.WriteLine("Enter the amount of number you want to introduce:");
            var inputCount = Console.ReadLine();

            if (int.TryParse(inputCount, out var count))
            {
                var isAscendingRotatedSeq = true;
                var ascendingSequence = false;
                var descendingSequence = false;

                Console.WriteLine("Enter a number:");
                var firstInput = Console.ReadLine();

                Console.WriteLine("Enter a number:");
                var secondInput = Console.ReadLine();

                if (int.TryParse(firstInput, out var secondLimit) && int.TryParse(secondInput, out var secondNumber))
                {
                    if (secondLimit < secondNumber)
                    {
                        ascendingSequence = true;
                    }
                    else
                    {
                        descendingSequence = true;
                    }

                    for (var i = 2; i < count; i++)
                    {
                        Console.WriteLine("Enter a number:");
                        var followingInput = Console.ReadLine();

                        if (int.TryParse(followingInput, out var followingNumber))
                        {
                            if (ascendingSequence && secondNumber > followingNumber)
                            {
                                isAscendingRotatedSeq = IsAscendingRotatedSequence(i, count, followingNumber, secondLimit, isAscendingRotatedSeq, followingNumber);
                                break;
                            }
                            
                            if (descendingSequence && secondNumber < followingNumber)
                            {
                                if (followingNumber < secondNumber || followingNumber > secondLimit)
                                {
                                    isAscendingRotatedSeq = false;
                                }
                                isAscendingRotatedSeq = IsAscendingRotatedSequence(i, count, secondNumber, secondLimit, isAscendingRotatedSeq, followingNumber);
                                break;
                            }
                        }

                        secondNumber = followingNumber;
                    }
                }

                string Message() => isAscendingRotatedSeq
                    ? "Your sequence is for sure an ascending rotated sequence!"
                    : "Your sequence is not an ascending rotated one!";

                Console.WriteLine(Message());
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }

        private static bool IsAscendingRotatedSequence(int i, int count, int firstLimit, int secondLimit, bool isAscendingRotatedSequence, int followingNumber)
        {
            var tempNumberHolder = followingNumber;
            for (var x = i + 1; x < count; x++)
            {
                Console.WriteLine("Enter a number:");
                var anotherInput = Console.ReadLine();
                if (int.TryParse(anotherInput, out var anotherNumber))
                {
                    if (anotherNumber < firstLimit || anotherNumber > secondLimit ||
                        anotherNumber < tempNumberHolder)
                    {
                        isAscendingRotatedSequence = false;
                    }
                }

                tempNumberHolder = followingNumber;
            }

            return isAscendingRotatedSequence;
        }
    }
}