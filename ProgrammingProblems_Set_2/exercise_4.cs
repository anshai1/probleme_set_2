using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_4
    {
        public static void FindPosition()
        {
            var position = -1;
            
            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the searched element:");
            var searched = int.Parse(Console.ReadLine());

            foreach (int element in Enumerable.Range(0, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());

                if (input == searched)
                {
                    position = element;
                }
            }
            
            var message = position == -1 ? 
                "The searched element was not found" :
                $"The searched element has the position: {position}";
            
            Console.WriteLine(message);
        } 
    }
}