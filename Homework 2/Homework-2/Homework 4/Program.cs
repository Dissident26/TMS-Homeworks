// #1 
int[] array = GetFieldArray();
// #1.4 Вычислить сумму элементов с нечетными номерами(индексами) и вывести эту сумму на экран
int summOfAllOdds = GetAllOddNumbersSumm(array);
Console.WriteLine("Сумма всех нечётных элементов: {0}", summOfAllOdds);
// # 1.5 Найти минимальный элемент в массиве и вывести его на экран.
int min = GetMinFromIntArray(array);
Console.WriteLine("Минимальный эдлемент массива: {0}", min);
// #2 Используя стек, выведите элементы массива в обратно порядке.
ReverseArrayByStack();

void ReverseArrayByStack()
{
    int[] randomArray = new int[5];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = i;
    }

    var stack = new Stack<int>(randomArray);

    foreach (var number in stack)
    {
        Console.WriteLine(number);
    }
}
int GetMinFromIntArray (int[] array)
{
    return array.Min();
}
int GetAllOddNumbersSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
}
int[] GetFieldArray()
{
    Console.WriteLine("Задайте размерность массива: ");
    int input = ReadIntFromConsole();
    int[] array = new int[input];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Задайте значение элемента массива {0}: ", i);
        array[i] = ReadIntFromConsole();
    }
    return array;
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