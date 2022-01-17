using System;

namespace ProgrammingProblems_Set_2
{
    public class MessageUtils
    {

        public static void AskingNumbersWithCountOf(int numbersCount)
        {
            Console.WriteLine($"\nCome on, you can do better than that... I asked for {numbersCount} number(s)!\n" +
                              "Better luck next time.");
        }

        public static void NoWhiteSpacesAllowed()
        {
            Console.WriteLine("\nOh I see what are you doing... NO WHITE SPACES!");
        }

        public static void CantDivideWithZero()
        {
            Console.WriteLine("\nYou try to divide with 0. That's not ok...");
        }
        
    }
}