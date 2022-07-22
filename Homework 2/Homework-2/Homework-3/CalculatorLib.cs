namespace CalculatorLib
{
    public static class Calculator
    {
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Minus(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public static int DivideWIthRemains(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber;
        }
    }
}
