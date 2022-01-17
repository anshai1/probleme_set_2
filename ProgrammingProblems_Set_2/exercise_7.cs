using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_7
    {
        public static void MinAndMax()
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            
            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());

            foreach (int element in Enumerable.Range(1, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());

                if (input < min)
                {
                    min = input;
                }

                if (input > max)
                {
                    max = input;
                }
            }
            
            Console.WriteLine($"MIN value entered: {min}");
            Console.WriteLine($"MAX value entered: {max}");
        }
    }
}