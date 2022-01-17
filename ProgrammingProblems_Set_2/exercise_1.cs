using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_1
    {
        public static void CountEvenNumbers()
        {
            var evenCount = 0;
            
            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());
            
            foreach (int element in Enumerable.Range(1, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());
                if (isEven(input))
                {
                    evenCount++;
                }
            }
            
            Console.WriteLine($"You entered {evenCount} even number(s).");
        }

        private static bool isEven(int number)
        {
            return number % 2 == 0;
        }
        
    }
}