namespace ProgrammingProblems_Set_2
{
    public class ValidationUtils
    {
        
        public static bool DoesContainWhiteSpaces(string firstInput)
        {
            return string.IsNullOrWhiteSpace(firstInput);
        }
        
        public static bool DoesContainWhiteSpaces(string firstInput, string secondInput)
        {
            return string.IsNullOrWhiteSpace(firstInput) || string.IsNullOrWhiteSpace(secondInput);
        }
        
        public static bool DoesContainWhiteSpaces(string firstInput, string secondInput, string thirdInput)
        {
            return string.IsNullOrWhiteSpace(firstInput) || string.IsNullOrWhiteSpace(secondInput) || string.IsNullOrWhiteSpace(thirdInput);
        }
        
    }
}