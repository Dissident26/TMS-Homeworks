using Homework_11.Classes;

var emloyee = new Employee("Работник #1", 21, 1000);

PotentialyDangerousChanges(() =>
{
    emloyee.Age = 12;   //insert some not valid data here
});

static void PotentialyDangerousChanges(Action action)
{
    try
    {
        action();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
    }
}