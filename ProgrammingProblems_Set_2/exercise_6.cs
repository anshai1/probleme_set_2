using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_6
    {
        public static void IsOrdered()
        {
            var isOrdered = true;

            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());

            var previousValue = int.MinValue; 
            foreach (int element in Enumerable.Range(1, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());
                
                if (input < previousValue)
                {
                    isOrdered = false;
                }
                
                previousValue = input;
            }

            var message = isOrdered
                ? "The numbers entered are ordered"
                : "The numbers entered are NOT in an increasing order";
            
            Console.WriteLine(message);
        }
    }
}