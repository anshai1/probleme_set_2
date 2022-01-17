using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_5
    {
        public static void ValueEqualsPosition()
        {
            var equalCount = 0;
            
            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());

            foreach (int element in Enumerable.Range(0, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());

                if (input == element)
                {
                    equalCount++;
                }
            }
            
            Console.WriteLine($"{equalCount} number(s) is/are equal with the position");
        }
    }
}