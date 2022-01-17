using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_2
    {
        public static void CountNumberTypes()
        {
            var zeroCount = 0;
            var positiveCount = 0;
            var negativeCount = 0;

            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());

            foreach (int element in Enumerable.Range(1, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    negativeCount++;
                } else if (input == 0)
                {
                    zeroCount++;
                }
                else
                {
                    positiveCount++;
                }
            }
            
            Console.WriteLine($"You entered {zeroCount} zeros, {negativeCount} negative numbers and {positiveCount} positive numbers");
        }
    }
}