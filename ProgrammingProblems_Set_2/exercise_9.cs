using System;

namespace ProgrammingProblems_Set_2
{
    public class exercise_9
    {

        public static void IsNumberSequenceMonotone()
        {
            Console.WriteLine("Enter the amount of number you want to introduce:");
            var inputCount = Console.ReadLine();
            
            if (int.TryParse(inputCount, out var count))
            {
                Console.WriteLine("Enter a number:");
                var firstInput = Console.ReadLine();
                Console.WriteLine("Enter a number:");
                var secondInput = Console.ReadLine();
                
                var isMonotone = true;
                
                if (int.TryParse(firstInput, out var firstNumber) && int.TryParse(secondInput, out var followingNumber))
                {
                    var isSequenceGrowing = firstNumber < followingNumber;

                    for (var i = 2; i < count; i++)
                    {
                        Console.WriteLine("Enter a number:");
                        var input = Console.ReadLine();
                        if (int.TryParse(input, out var number))
                        {
                            if ((isSequenceGrowing && followingNumber > number) || (!isSequenceGrowing && followingNumber < number))
                            {
                                isMonotone = false;
                            }
                        }

                        followingNumber = number;
                    }

                    
                }
                string Message() => isMonotone
                    ? "\nThe entered sequence is monotone."
                    : "\nThe entered sequence is not monotone.";

                Console.WriteLine(Message());
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
            
        }
        
    }
}