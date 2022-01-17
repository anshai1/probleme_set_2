using System;

namespace ProgrammingProblems_Set_2
{
    public class exercise_11
    {

        public static void TotalSumOfTheInputInverses()
        {
            Console.WriteLine("Enter the amount of number you want to introduce:");
            var inputCount = Console.ReadLine();
            
            if (int.TryParse(inputCount, out var count))
            {
                Console.WriteLine("Enter a number:");
                var input = Console.ReadLine();

                if (int.TryParse(input, out var inputNumber))
                {
                    var result = ReverseNumber(inputNumber);
                    for (var i = 1; i < count; i++)
                    {
                        Console.WriteLine("Enter a number:");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out var number))
                        {
                            var reversedNumber = ReverseNumber(number);
                            result += reversedNumber;
                        }
                    }
                    Console.WriteLine($"Sum of the reversed numbers is: {result}");
                }
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }

        private static int ReverseNumber(int number)
        {
            var result = 0;
            while (number != 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }

            return result;
        }
        
    }
}