
var studentsDictionary = new Dictionary<string, int>()
{
    {"Иванов", 5 },
    {"Петров", 6 },
    {"Сидоров", 7 }
};

Menu(studentsDictionary);

void Menu(Dictionary<string, int> dictionary)
{
 

    MenuItem? consoleInput = null;

    while (consoleInput != MenuItem.End)
    {
        Console.WriteLine(@"
    Выберите действие: 
        1) Добавить оценку ученика.
        2) Изменить оценку ученика.
        3) Удалить оценку ученика.
        4) Вывести всех учеников в виде: Фамилия - Оценка.
        5) Вывести среднее арифметическое всех оценок.
        6) Вывести фамилии учеников, которые имеют самую высокую оценку среди одноклассников.
        7) Вывести фамилии учеников, которые имеют оценку большую или равную 8.
        8) Вывести фамилии учеников, которые имеют оценку меньшую или равную 4.
        9) Закончить программу.");

        consoleInput = (MenuItem)ReadIntFromConsole();

        switch (consoleInput)
        {
            case MenuItem.AddGrade:
                AddGrade(dictionary);
                break;
            case MenuItem.ChangeGrade:
                ChangeGrade(dictionary);
                break;
            case MenuItem.RemoveGrade:
                RemoveGrade(dictionary);
                break;
            case MenuItem.AllGrades:
                PrintAllGrades(dictionary);
                break;
            case MenuItem.AverageGrade:
                GetAverageGrade(dictionary);
                break;
            case MenuItem.HighestGrade:
                GetHighestGrade(dictionary);
                break;
            case MenuItem.GradeEqualOrMoreThan:
                GetNamesWithGradeEqualOrMoreThan(8, dictionary);
                break;
            case MenuItem.GradeEqualOrLessThen:
                GetNamesWithGradeEqualOrLessThen(4, dictionary);
                break;
            case MenuItem.End:
                return;
            default: Console.WriteLine("Invalid Input!");
                break;
        }
    }
}
void GetNamesWithGradeEqualOrLessThen(int grade, Dictionary<string, int> dictionary)
{
    var namesArray = dictionary.Where(x => x.Value <= grade).ToArray();
    Console.WriteLine("Студенты с оценкой меньше или равно {0}: ", grade);
    foreach (var student in namesArray)
    {
        Console.WriteLine("Студент {0}", student.Key);
    }
};
void GetNamesWithGradeEqualOrMoreThan(int grade, Dictionary<string, int> dictionary)
{
    var namesArray = dictionary.Where(x => x.Value >= grade).ToArray();
    Console.WriteLine("Студенты с оценкой выше или равно {0}: ", grade);
    foreach (var student in namesArray)
    {
        Console.WriteLine("Студент {0}", student.Key);
    }
};
void GetHighestGrade(Dictionary<string, int> dictionary)
{
    KeyValuePair<string, int>[] gradesArray = dictionary.ToArray();
    string name = gradesArray.Max(x => x.Key);
    Console.WriteLine("Наивысший бал {0}", name);
};
void GetAverageGrade(Dictionary<string, int> dictionary)
{
    int summ = 0;
    foreach (var student in dictionary)
    {
        summ += student.Value;
    }

    Console.WriteLine("Средняя оценка: {0}", summ / dictionary.Count);    
}
void PrintAllGrades(Dictionary<string, int> dictionary)
{
    foreach (var student in dictionary)
    {
        Console.WriteLine("Студент: {0}, Оценка: {1}", student.Key, student.Value);
    }

};
void RemoveGrade(Dictionary<string, int> dictionary)
{
    string studentsName = ReadStudentsNameFromConsole();
    if (!dictionary.ContainsKey(studentsName))
    {
        Console.WriteLine("Такого ученика нет в базе.");
        return;
    }

    dictionary.Remove(studentsName);
};
void ChangeGrade(Dictionary<string, int> dictionary)
{
    string studentsName = ReadStudentsNameFromConsole();
    if (!dictionary.ContainsKey(studentsName))
    {
        Console.WriteLine("Такого ученика нет в базе.");
        return;
    }

    Console.WriteLine("Введите оценку: ");
    int grade = ReadIntFromConsole();

    dictionary[studentsName] = grade;
}
void AddGrade(Dictionary<string, int> dictionary)
{
    string studentsName = ReadStudentsNameFromConsole();
    if (dictionary.ContainsKey(studentsName))
    {
        Console.WriteLine("Такой ученик уже существует.");
        return;
    }

    Console.WriteLine("Введите оценку: ");
    int grade = ReadIntFromConsole();

    dictionary.Add(studentsName, grade);
}
string ReadStudentsNameFromConsole()
{
    Console.WriteLine("Введите фамилию ученика: ");
    return Console.ReadLine();
};
int ReadIntFromConsole()
{
    string? input = Console.ReadLine();
    bool isNumberValid = int.TryParse(input, out int number);

    if (!isNumberValid)
    {
        throw new Exception("Invalid Number Entered!");
    }

    return number;
}
enum MenuItem
{
    AddGrade = 1,
    ChangeGrade = 2,
    RemoveGrade = 3,
    AllGrades = 4,
    AverageGrade = 5,
    HighestGrade = 6,
    GradeEqualOrMoreThan = 7,
    GradeEqualOrLessThen = 8,
    End = 9,
}