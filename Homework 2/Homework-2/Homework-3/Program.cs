using CalculatorLib;
// #1. Сделать консольный калькулятор.
CalculatorWithInterface();
// #2. Пользователь вводит 3 целых числа A, B, C.
GetThreeNumbersEquation();

void GetThreeNumbersEquation()
{
    int A = ReadIntFromConsole();
    int B = ReadIntFromConsole();
    int C = ReadIntFromConsole();

    if (A > 100 && B > 100)
    {
        Console.WriteLine("Каждое из чисел А и В больше 100");
    }
    if (A > 100 || B > 100)
    {
        Console.WriteLine("Только одно из чисел А и В четное");
    }
    if (A > 0 || B > 0)
    {
        Console.WriteLine("Одно из чисел А и В положительное");
    }
    if (A % 3 == 0 && B % 3 == 0 && C % 3 == 0)
    {
        Console.WriteLine("Каждое из чисел А, В, С кратно трем");
    }
    if ((A < 50 ^ B < 50) ^ C < 50)
    {
        Console.WriteLine("Только одно из чисел А, В и С меньше 50");
    }

};
void CalculatorWithInterface()
{
    Console.WriteLine("Калькулятор");
    int firstNumber = ReadIntFromConsole();
    int secondNumber = ReadIntFromConsole();
    string operation = Console.ReadLine();

    int result = Calculate(firstNumber, secondNumber, operation);

    Console.WriteLine("{0} {2} {1} = {3}", firstNumber, secondNumber, operation, result);
}
int ReadIntFromConsole()
{
    Console.WriteLine("Введите число: ");
    string? input = Console.ReadLine();
    bool isNumberValid = int.TryParse(input, out int number);

    if (!isNumberValid)
    {
        throw new Exception("Invalid Number Entered!");
    }

    return number;
}
int Calculate(int firstNumber, int secondNumber, string operation)
{
    OperationType operationType = GetOperationType(operation);

    switch (operationType)
    {
        case OperationType.Add: return Calculator.Add(firstNumber, secondNumber);
        case OperationType.Minus: return Calculator.Minus(firstNumber, secondNumber);
        case OperationType.Multiply: return Calculator.Multiply(firstNumber, secondNumber);
        case OperationType.Divide: return Calculator.Divide(firstNumber, secondNumber);
        case OperationType.DivideWithRemains: return Calculator.DivideWIthRemains(firstNumber, secondNumber);
        default: throw new Exception("Invalid operation!");
    }
}
OperationType GetOperationType(string operation)
{
    Dictionary<string, OperationType> OperationTypeDictionary = new()
    {
        { "+", OperationType.Add },
        { "-", OperationType.Minus },
        { "*", OperationType.Multiply },
        { "/", OperationType.Divide },
        { "%", OperationType.DivideWithRemains },
    };
    OperationTypeDictionary.TryGetValue(operation, out OperationType value);

    return value;
}
enum OperationType
{
    Add,
    Minus,
    Multiply,
    Divide,
    DivideWithRemains
}

