using System;

namespace ProgrammingProblems_Set_2
{
    public class exercise_8
    {
        public static void NthFibonacci()
        {
            Console.WriteLine("Enter the index of the Fibonacci number that you want to see: ");
            var index = int.Parse(Console.ReadLine());

            var requestedFibonacci = Fibonacci(index);
            
            Console.WriteLine("");
        }
        
        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}