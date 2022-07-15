namespace MathFunctions
{
    public static class Factorial
    {
        public static int GetFactorialRecursion(int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number * GetFactorialRecursion(number - 1);
        }

        public static int GetFactorialLoop(int number)
        {
            int result = 1;
            for (int i = result; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
