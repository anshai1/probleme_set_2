using System;
using System.Linq;

namespace ProgrammingProblems_Set_2
{
    public class exercise_3
    {
        public static void SumAndProduct()
        {
            int sum = 0;
            int product = 1;
            
            Console.WriteLine("Enter the number of elemnts:");
            var range = int.Parse(Console.ReadLine());

            foreach (int element in Enumerable.Range(1, range))
            {
                Console.WriteLine($"Enter number [{element}]: ");
                var input = int.Parse(Console.ReadLine());

                sum += input;
                product *= input;
            }
            
            Console.WriteLine($"The sum of the entered numbers is: {sum}");
            Console.WriteLine($"The product of the entered numbers is: {product}");
        }
    }
}